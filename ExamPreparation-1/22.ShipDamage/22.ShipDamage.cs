using System;

class ShipDamage
{
    static void Main()
    {
        int[] shipCoordinates = new int[4];
        int leftSide, rightSide, topSide, bottomSide;

        for (int i = 0; i < 4; i++)
        {
            shipCoordinates[i] = int.Parse(Console.ReadLine());
        }
        int horizontal = int.Parse(Console.ReadLine());
        int catapultOneX = int.Parse(Console.ReadLine());
        int catapultOneY = int.Parse(Console.ReadLine());
        int catapultTwoX = int.Parse(Console.ReadLine());
        int catapultTwoY = int.Parse(Console.ReadLine());
        int catapultThreeX = int.Parse(Console.ReadLine());
        int catapultThreeY = int.Parse(Console.ReadLine());        
        leftSide = Math.Min(shipCoordinates[0],shipCoordinates[2]);
        rightSide = Math.Max(shipCoordinates[0], shipCoordinates[2]);
        bottomSide = Math.Min(shipCoordinates[1], shipCoordinates[3]);
        topSide = Math.Max(shipCoordinates[1], shipCoordinates[3]);

        int missleOneYCoords = 2*horizontal-catapultOneY;
        int missleTwoYCoords = 2*horizontal-catapultTwoY;
        int missleThreeYCoords = 2*horizontal-catapultThreeY;
        int missleOneXCoords = catapultOneX;
        int missleTwoXCoords = catapultTwoX;
        int missleThreeXCoords = catapultThreeX;

        int damage = 0;
        //first catapult
        if ((missleOneXCoords > leftSide && missleOneXCoords < rightSide) && (missleOneYCoords > bottomSide && missleOneYCoords < topSide))
        {
            damage += 100;
        }
        if ((missleOneXCoords == leftSide && missleOneYCoords > bottomSide && missleOneYCoords < topSide) || (missleOneXCoords == rightSide && missleOneYCoords > bottomSide && missleOneYCoords < topSide))
        {
            damage += 50;
        }
        if ((missleOneYCoords == topSide || missleOneYCoords == bottomSide) && (missleOneXCoords > leftSide && missleOneXCoords < rightSide))
        {
            damage += 50;
        }
        if ((missleOneXCoords == leftSide || missleOneXCoords == rightSide) && (missleOneYCoords == bottomSide || missleOneYCoords == topSide))
        {
            damage += 25;
        }
        //second catapult
        if ((missleTwoXCoords > leftSide && missleTwoXCoords < rightSide) && (missleTwoYCoords > bottomSide && missleTwoYCoords < topSide))
        {
            damage += 100;
        }
        if ((missleTwoXCoords == leftSide && missleTwoYCoords > bottomSide && missleTwoYCoords < topSide) || (missleTwoXCoords == rightSide && missleTwoYCoords > bottomSide && missleTwoYCoords < topSide))
        {
            damage += 50;
        }
        if ((missleTwoYCoords == topSide || missleTwoYCoords == bottomSide) && (missleTwoXCoords > leftSide && missleTwoXCoords < rightSide))
        {
            damage += 50;
        }
        if ((missleTwoXCoords == leftSide || missleTwoXCoords == rightSide) && (missleTwoYCoords == bottomSide || missleTwoYCoords == topSide))
        {
            damage += 25;
        }
        //third catapult
        if ((missleThreeXCoords > leftSide && missleThreeXCoords < rightSide) && (missleThreeYCoords > bottomSide && missleThreeYCoords < topSide))
        {
            damage += 100;
        }
        if ((missleThreeXCoords == leftSide && missleThreeYCoords > bottomSide && missleThreeYCoords < topSide) || (missleThreeXCoords == rightSide && missleThreeYCoords > bottomSide && missleTwoYCoords < topSide))
        {
            damage += 50;
        }
        if ((missleThreeYCoords == topSide || missleThreeYCoords == bottomSide) && (missleThreeXCoords > leftSide && missleThreeXCoords < rightSide))
        {
            damage += 50;
        }
        if ((missleThreeXCoords == leftSide || missleThreeXCoords == rightSide) && (missleThreeYCoords == bottomSide || missleThreeYCoords == topSide))
        {
            damage += 25;
        }

        Console.WriteLine("{0}%",damage);
    }
}