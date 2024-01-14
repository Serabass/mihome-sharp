using System.Diagnostics;

namespace SpeechGen.Balcon;

public class BalconLocal : BalconBase
{
    private readonly string _balconPath = @"M:\dev\csharp\mihome\SpeechGen\balcon-bin\balcon-bin\balcon.exe";

    private readonly string _balconVoice;

    public override async Task<string> ConvertWavToOgg(string wavPath)
    {
        var tmpPath = $"{Path.GetTempFileName()}.ogg";
        Process process = new();
        process.StartInfo.FileName = "ffmpeg";
        process.StartInfo.Arguments = $"-i \"{wavPath}\" -acodec libopus -b:a 128k \"{tmpPath}\"";
        process.Start();
        process.WaitForExit();
        File.Delete(wavPath);
        return tmpPath;
    }

    public override async Task<string> GenerateSpeechWav(string text)
    {
        var tmpPath = $"{Path.GetTempFileName()}.wav";
        Process process = new();
        process.StartInfo.FileName = _balconPath;
        process.StartInfo.Arguments = $"-n \"{_balconVoice}\" -t \"{text}\" -w \"{tmpPath}\"";
        process.Start();
        process.WaitForExit();
        return tmpPath;
    }
}
