
float PlayerSpeed = 10;
SetSpeed(2.5f);

void SetSpeed(float Sp)
{
    Console.WriteLine("The original speed "+ PlayerSpeed);
    //PlayerSpeed = Sp;
    Console.WriteLine("The new speed "+ Sp);

    if (PlayerSpeed > Sp)
    {
        Console.WriteLine("My speed is " +PlayerSpeed);
    }
    else
    {
        Console.WriteLine("My speed is lower "+ Sp);
    }
}

