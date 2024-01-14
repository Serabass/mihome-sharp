namespace SpeechGen.Balcon;

public abstract class BalconBase
{
  public abstract Task<string> GenerateSpeechWav(string text);
  // public abstract Task<string> ConvertWavToOgg(string wavPath);
}
