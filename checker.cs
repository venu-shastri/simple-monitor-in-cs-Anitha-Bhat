using System;
using System.Diagnostics;

class Checker
{
  static bool batteryIsOk(float temperature, float stateOfCharge, float chargeRate)
  {
    return isTemperatureInRange(temperature) && isStateOfChargeInRange(stateOfCharge) && isChargeRateInRange(chargeRate);
   
  }

  private static bool isTemperatureInRange(float temperature)
  {
    if (temperature < 0 || temperature > 45)
    {
      printText("Temperature is out of range!");
      return false;
    }

    return true;
  }

  private static bool isStateOfChargeInRange(float stateOfCahrge)
  {
    if (stateOfCahrge < 20 || stateOfCahrge > 80)
    {
      printText("State of Charge is out of range!");
      return false;
    }
    return true;
  }

  private static bool isChargeRateInRange(float chargeRate)
  {
    if (chargeRate > 0.8)
    {
      printText("Charge Rate is out of range!");
      return false;
    }

    return true;
  }

  private static void printText(string text)
  {
    Console.WriteLine(text);
  }

  static int Main()
  {
   using System;
using System.Diagnostics;

class Checker
{
  static bool batteryIsOk(float temperature, float stateOfCharge, float chargeRate)
  {
    return isTemperatureInRange(temperature) && isStateOfChargeInRange(stateOfCharge) && isChargeRateInRange(chargeRate);
   
  }

  private static bool isTemperatureInRange(float temperature)
  {
    if (temperature < 0 || temperature > 45)
    {
      printText("Temperature is out of range!");
      return false;
    }

    return true;
  }

  private static bool isStateOfChargeInRange(float stateOfCahrge)
  {
    if (stateOfCahrge < 20 || stateOfCahrge > 80)
    {
      printText("State of Charge is out of range!");
      return false;
    }
    return true;
  }

  private static bool isChargeRateInRange(float chargeRate)
  {
    if (chargeRate > 0.8)
    {
      printText("Charge Rate is out of range!");
      return false;
    }

    return true;
  }

  private static void printText(string text)
  {
    Console.WriteLine(text);
  }

  static int Main()
  {


    Debug.Assert(batteryIsOk(25, 70, 0.7f));
    Debug.Assert(!batteryIsOk(50, 85, 0.0f));
    Debug.Assert(!batteryIsOk(0, 19, 1f));
    Debug.Assert(!batteryIsOk(1, 21, 1f));
    Debug.Assert(!batteryIsOk(1, 81, 0.7f));
    Debug.Assert(!batteryIsOk(-1, 79, 0.7f));
    Debug.Assert(batteryIsOk(1, 21, 0.7f));
    Debug.Assert(batteryIsOk(44, 79, 0.7f));
    Console.WriteLine("All ok");
    Console.Read();
    return 0;
  }
}
