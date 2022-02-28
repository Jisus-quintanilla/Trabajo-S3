Console.WriteLine($"Elija la opción");
Console.WriteLine($"1 - Desglose de cantidad");
Console.WriteLine($"2 - Convertir de $ a Q y Desglosarlo");
int opcion;
opcion = Convert.ToInt32(Console.ReadLine());

switch(opcion)
{
    case 1:
static void desglose()
{
    int G1, C200, C100, C50, C20, C10, C5, sob;
    C200 = C100 = C50 = C20 = C10 = C5 = 0;

    float G2, c50, c25, c10, c5, c1, CAN;
    c50 = c25 = c10 = c5 = c1 = 0.0f;

    float sc50, sc25, sc10, sc5;
    sc50 = sc25 = sc10 = sc5 = 0.0f;

    Console.WriteLine("Ingrese la cantidad que desea desglosar");
    CAN = Convert.ToSingle(Console.ReadLine());

    if ((CAN >= 200))
    {
        C200 = (int)(CAN / 200);
        CAN = CAN - (C100 * 200);
    }

    if ((CAN >= 100))
    {
        C100 = (int)(CAN / 100);
        CAN = CAN - (C100 * 100);
    }
    if ((CAN >= 50))
    {
        C50 = (int)(CAN / 50);
        CAN = CAN - (C50 * 50);
    }
    if ((CAN >= 20))
    {
        C20 = (int)(CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (int)(CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (int)(CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    G1 = (int)CAN;
    sob = (int)CAN;
    G2 = (float)sob;
    CAN = (float)(-sob + CAN);

    //Centavos

    if (CAN >= 0.50f)
    {
        c50 = (CAN / 0.50f);
        sc50 = (-0.50f + CAN);

    }

    if ((sc50 >= 0.25f))
    {
        c25 = (sc50 / 0.25f);
        sc25 = (-0.25f + sc50);

    }

    if ((sc25 >= 0.10f))
    {
        c10 = (sc25 / 0.10f);
        sc10 = (-0.10f + sc25);
    }

    if ((sc10 >= 0.05f))
    {
        c5 = (sc10 / 0.05f);
        sc5 = (-0.05f + sc10);
    }

    if ((sc5 >= 0.01f))
    {
        c1 = (sc5 / 0.01f) + 0.01f;

    }
    Console.WriteLine($"\nEl desglose es:");
    Console.WriteLine($"BILLETES DE 200: {C200}");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE 50: {C50}");
    Console.WriteLine($"BILLETES DE 20: {C20}");
    Console.WriteLine($"BILLETES DE 10: {C10}");
    Console.WriteLine($"BILLETES DE 5: {C5}");
    Console.WriteLine($"BILLETES DE 1: {G1}");

    Console.WriteLine($"CENTAVOS DE 0.50: {c50}");
    Console.WriteLine($"CENTAVOS DE 0.25: {c25}");
    Console.WriteLine($"CENTAVOS DE 0.10: {c10}");
    Console.WriteLine($"CENTAVOS DE 0.05: {c5}");
    Console.WriteLine($"CENTAVOS DE 0.01: {c1}");
}

desglose();
        break;
    case 2:
static void ConverciónDolarQuetzal()
{
    int G1, C200, C100, C50, C20, C10, C5, sob;
    C200 = C100 = C50 = C20 = C10 = C5 = 0;

    float G2, c50, c25, c10, c5, c1, CAN;
    c50 = c25 = c10 = c5 = c1 = 0.0f;

    float sc50, sc25, sc10, sc5;
    sc50 = sc25 = sc10 = sc5 = 0.0f;

    Console.WriteLine("Ingrese la cantidad en dolares");
    CAN = Convert.ToSingle(Console.ReadLine());

    CAN = (float)(CAN * 7.66);

    Console.WriteLine($"La cantidad de Dolares a Quetzales es: Q{CAN}");

    Console.WriteLine($"\nEl desglose de los Quetzales es:");

    if ((CAN >= 200))
    {
        C200 = (int)(CAN / 200);
        CAN = CAN - (C100 * 200);
    }

    if ((CAN >= 100))
    {
        C100 = (int)(CAN / 100);
        CAN = CAN - (C100 * 100);
    }
    if ((CAN >= 50))
    {
        C50 = (int)(CAN / 50);
        CAN = CAN - (C50 * 50);
    }
    if ((CAN >= 20))
    {
        C20 = (int)(CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (int)(CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (int)(CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    G1 = (int)CAN;
    sob = (int)CAN;
    G2 = (float)sob;
    CAN = (float)(-sob + CAN);

    //Centavos

    if (CAN >= 0.50f)
    {
        c50 = (CAN / 0.50f);
        sc50 = (-0.50f + CAN);

    }

    if ((sc50 >= 0.25f))
    {
        c25 = (sc50 / 0.25f);
        sc25 = (-0.25f + sc50);

    }

    if ((sc25 >= 0.10f))
    {
        c10 = (sc25 / 0.10f);
        sc10 = (-0.10f + sc25);
    }

    if ((sc10 >= 0.05f))
    {
        c5 = (sc10 / 0.05f);
        sc5 = (-0.05f + sc10);
    }

    if ((sc5 >= 0.01f))
    {
        c1 = (sc5 / 0.01f) + 0.01f;

    }

    Console.WriteLine($"BILLETES DE Q200: {C200}");
    Console.WriteLine($"BILLETES DE Q100: {C100}");
    Console.WriteLine($"BILLETES DE Q50: {C50}");
    Console.WriteLine($"BILLETES DE Q20: {C20}");
    Console.WriteLine($"BILLETES DE Q10: {C10}");
    Console.WriteLine($"BILLETES DE Q5: {C5}");
    Console.WriteLine($"BILLETES DE Q1: {G1}");

    Console.WriteLine($"CENTAVOS DE Q0.50: {c50}");
    Console.WriteLine($"CENTAVOS DE Q0.25: {c25}");
    Console.WriteLine($"CENTAVOS DE Q0.10: {c10}");
    Console.WriteLine($"CENTAVOS DE Q0.05: {c5}");
    Console.WriteLine($"CENTAVOS DE Q0.01: {c1}");

}

ConverciónDolarQuetzal();
        break;
}
