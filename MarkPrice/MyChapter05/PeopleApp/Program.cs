﻿using MyPackt.Shared;
using MyPacktLibrary;
using static System.Console;

Person bob = new Person();
//Console.WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later
Console.WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
arg0: bob.Name,
arg1: bob.DateOfBirth);

//Person alice = new()
//{
//    Name = "Alice Jones",
//    DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
//};
//WriteLine(format: "{0} was born on {1:dd MMM yy}",
//arg0: alice.Name,
//arg1: alice.DateOfBirth);

//bob.FavoriteAncientWonder = WondersOfTheAncientWorld.
//StatueOfZeusAtOlympia;
//WriteLine(
//format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
//arg0: bob.Name,
//arg1: bob.FavoriteAncientWonder,
//arg2: (int)bob.FavoriteAncientWonder);


//bob.BucketList =
//WondersOfTheAncientWorld.HangingGardensOfBabylon
//| WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
//// bob.BucketList = (WondersOfTheAncientWorld)18;
//WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

//bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 and later
//bob.Children.Add(new() { Name = "Zoe" }); // C# 9.0 and later
//WriteLine($"{bob.Name} has {bob.Children.Count} children:");
//for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
//{
//    WriteLine($" {bob.Children[childIndex].Name}");
//}

BankAccount.InterestRate = 0.012M; // store a shared value

BankAccount jonesAccount = new(); // C# 9.0 and later
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: gerrierAccount.AccountName,
arg1: gerrierAccount.Balance * BankAccount.InterestRate);