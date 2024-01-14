using SpeechGen.Balcon;

var b = new BalconLocal();
var text = "Пошел нахуй";
var wavPath = await b.GenerateSpeechWav(text);
// var oggPath = await b.ConvertWavToOgg(wavPath);

Console.WriteLine($"Generated speech ogg: {wavPath}");
