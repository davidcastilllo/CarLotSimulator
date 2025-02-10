using System;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator;

public class Car {

 public Car() {
  CarLot.numberOfCars++;
 }

 public int Year { get; set; }
 public string Make { get; set; }
 public string Model { get; set; }
 public string EngineNoise { get; set; }
 public string HonkNoise { get; set; }
 public bool IsDriveable { get; set; }

 public void MakeEngineNoise(string engineNoise) {
  EngineNoise = engineNoise;
  Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}.");
 }

public void MakeHonkNoise(string honkNoise) {
  honkNoise = HonkNoise;
  Console.WriteLine($"{Make} {Model} has an honk noise that sounds like {HonkNoise}.");
 }

}