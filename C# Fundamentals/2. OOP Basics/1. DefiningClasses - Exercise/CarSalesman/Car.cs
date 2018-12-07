namespace CarSalesman {
  public class Car {
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car(string model, Engine engine) {
      this.model = model;
      this.engine = engine;
      this.weight = "n/a";
      this.color = "n/a";
    }

    public string Model {
      get { return this.model; }
      set { this.model = value; }
    }

    public Engine Engine {
      get { return this.engine; }
      set { this.engine = value; }
    }
    public string Weight {
      get { return this.weight; }
      set { this.weight = value; }
    }

    public string Color {
      get { return this.color; }
      set { this.color = value; }
    }

    public override string ToString() {
      return $"{this.model}: \n" +
        $"  {this.engine.Model}:\n" +
        $"    Power: {this.engine.Power}\n" +
        $"    Displacement: {this.engine.Displacement}\n" +
        $"    Efficiency: {this.engine.Efficiency}\n" +
        $"  Weight: {this.weight}\n" +
        $"  Color: {this.color}";
    }
  }
}