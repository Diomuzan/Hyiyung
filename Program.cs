using System;
string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };
foreach (string name in names) {
    if (name == "Sophia") {
        Console.WriteLine(SophiaMessage());
    } else if (name == "Andrew") {
        Console.WriteLine(AndrewMessage());
    } else if (name == "AllGreetings") {
        Console.WriteLine(SophiaMessage());
        Console.WriteLine(AndrewMessage());
    }
}
static string SophiaMessage() {
    return "Hello, my name is Sophia.";
}
static string AndrewMessage() {
    return "Hi, my name is Andrew. Good to meet you.";
}
Console.WriteLine("\n"); 

string? readResult;
int startIndex = 0;
bool goodEntry = false;
int[] numbers = { 1, 2, 3, 4, 5 };
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers) {
    Console.Write($"{number} ");
}
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false) {
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);
    if (startIndex > 5) {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");
static int SumValues(int[] numbers, int n) {
    int sum = 0;
    for (int i = n; i < numbers.Length; i++) {
        sum += numbers[i];
    }
    return sum;
}
Console.WriteLine("\n");

int x = 5;
ChangeValue(x);
Console.WriteLine(x);
void ChangeValue(int value) {
    value = 10;
}



