using System;

// declare interface

interface IRecoverable

{

// function.

void Recover();

}

// Class

class Patient : IRecoverable

{

// function.

public void Recover()

{

Console.WriteLine("I am getting better");

}

}

// Class

class Upholsterer : IRecoverable

{

// function.

public void Recover()

{

Console.WriteLine("I have new material for the couch");

}

}

// Class

class FootballPlayer : IRecoverable

{

// function.

public void Recover()

{

Console.WriteLine("I picked up the ball after a fumble");

}

}

// main class

class Program

{

static void Main()

{

// Call functions

Patient p = new Patient();

p.Recover();

Upholsterer uh = new Upholsterer();

uh.Recover();

FootballPlayer fp = new FootballPlayer();

fp.Recover();

Console.ReadKey();

}

}
