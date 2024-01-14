namespace SpeechGen;

public abstract class BalconBase
{
  public abstract Task<string> GenerateSpeech(string text);
}
