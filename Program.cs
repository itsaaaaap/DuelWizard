// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
﻿
Wizard wizardsa = new Wizard("Wizard Kemi", 20);
Wizard wizardsb = new Wizard("WIzard Yami", 30);

Console.WriteLine("Permainan Dimulai . . . \n");
wizardsa.ShowStats();
wizardsb.ShowStats();

wizardsa.Attack(wizardsb);
wizardsb.Attack(wizardsa);
wizardsa.Attack(wizardsb);

Console.WriteLine("Permainan Berakhir . . . \n");
wizardsa.ShowStats();
wizardsb.ShowStats();
S
public class Wizard
{

    //deklarasi field
    public string Nama;
    public int Energy;
    public int Damage;

    //deklarasi constructor
    public Wizard(string name, int damage)
    {
        Nama = name;
        Energy = 100;
        Damage = damage;


    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Nama}, Energi: {Energy} \n");
    }

}
