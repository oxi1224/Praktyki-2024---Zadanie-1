FileStream f = File.Open("C:\\test\\test_ale_woj.txt", FileMode.Open);
StreamReader sr = new(f);

int liczba_a = 0;
foreach (char c in sr.ReadToEnd()) {
  if (c == 'a') liczba_a++;
}
Console.WriteLine($"Liczba \"a\" w pliku: {liczba_a}");
sr.Close();
f.Close();