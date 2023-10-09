Dictionary<char, int> notes = new Dictionary<char, int>()
{
{'Q',1 },
{'W',1 },
{'E',2 },
{'R',2},
{'T',3 },
{'Y',3 },
{'U',4 },
{'I',4 },
{'O',5 },
{'P',5 },
{'A',6 },
{'S',6 },
{'D',7 },
{'F',7 },
{'G',8 },
{'H',8 },
{'J',9 },
{'K',9 },
{'L',10 },
{'Z',10 },
{'X',11 },
{'C',11 },
{'V',12 },
{'B',12 },
{'M',12 },
{'N',12 },
{'Й',1 },
{'Ц',1 },
{'У',2 },
{'К',2},
{'Е',3 },
{'Н',3 },
{'Г',4 },
{'Ш',4 },
{'Щ',5 },
{'З',5 },
{'Ф',6 },
{'Ы',6 },
{'В',7 },
{'А',7 },
{'П',8 },
{'Р',8 },
{'О',9 },
{'Л',9 },
{'Д',10 },
{'Я',10 },
{'Ч',11 },
{'С',11 },
{'М',12 },
{'И',12 },
{'Т',12 },
{'Ь',12 }
};
int[] octava1 = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
int[] octava2 = { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
bool octava_two = false;
Console.WriteLine("Вводите буквы, чтобы играть на пианино или введите F1 или F2, чтобы сменить октаву:\n");
while (true)
{
    var key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.F2) octava_two = true;
    if (key.Key == ConsoleKey.F1) octava_two = false;
    if (char.IsLetter(key.KeyChar)) pianino_game(key.KeyChar);
}
void pianino_game(char a)
{
    try
    {
        Console.Beep(octava_two == false ? octava1[notes[char.ToUpper(a)] - 1] * 4 : octava2[notes[char.ToUpper(a)] - 1], 100);
    }
    catch { }
}