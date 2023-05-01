Console.WriteLine("--- Fluxograma Da Engenharia ---\n");

Console.WriteLine("O objeto esta se movendo(S/N)?");
string movendo = Console.ReadLine()!.Substring(0,1).ToUpper();


if(movendo == "S"){
Console.WriteLine("Deveria? S/N");
string deveria = Console.ReadLine()!.Substring(0,1).ToUpper();
if (deveria == "S"){
    Console.WriteLine("Ótimo!");
} 
else if(deveria == "N"){
    Console.WriteLine("Use SilverTape.");
}
else {
    Console.WriteLine("Use apenas S/N");
}
}



if (movendo == "N"){
    Console.WriteLine("Deveria? S/N");
    string deveria = Console.ReadLine()!.Substring(0,1).ToUpper();
    if(deveria == "S"){
        Console.WriteLine("Use  WD-40.");
    }
    else if (deveria == "N"){
        Console.WriteLine("Ótimo!");
    }
    else {Console.WriteLine("Use apenas S/N");
}
}



    
  