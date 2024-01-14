using System.Diagnostics;
using System.Text;

namespace SpeechGen.Balcon;

public class BalconLocal : BalconBase
{
    private readonly string _balconPath = @"M:\dev\csharp\mihome\SpeechGen\balcon-bin\balcon.exe";

    private readonly string _balconVoice = "IVONA 2 Maxim OEM";

    private string _buildArgs(Dictionary<string, string> args)
    {
        var sb = new StringBuilder();
        foreach (var (key, value) in args)
        {
            sb.Append($"-{key} \"{value}\" ");
        }

        return sb.ToString();
    }

    public override async Task<string> GenerateSpeechWav(string text)
    {
        var tmpPath = @"M:\dev\csharp\mihome\SpeechGen\bin\Debug\net8.0\1.wav";
        Process process = new();
        process.StartInfo.FileName = _balconPath;
        process.StartInfo.Arguments = _buildArgs(new Dictionary<string, string>
        {
            {"n", _balconVoice},
            {"t", text},
            {"w", tmpPath}
        });
        process.Start();
        process.WaitForExit();
        return tmpPath;
    }
}
