using MihomeCLI;
using SpeechGen.Balcon;

var b = new BalconLocal();
var text = "Hello, world!";
var wavPath = await b.GenerateSpeechWav(text);
// var oggPath = await b.ConvertWavToOgg(wavPath);

Console.WriteLine($"Generated speech ogg: {wavPath}");
