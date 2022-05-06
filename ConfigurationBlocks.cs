// C# program to illustrate the
// concept of inheritance in the
// constructor when the derived
// class contains a constructor
using System;
  
// Class Block 
public class Block {
  
    int code;
    // Properties for Radius and Height
    public int id_code
    {
        get { 
               return code; 
            }
  
        set {
               code = value < 0 ? -value : value;
            }
    }
    // Display BlockCode
    public void display_BlockCode()
    {
       Console.WriteLine("Code ID:" + id_code);
    }
}
 
// A derived class MorphologyBlock
// inheriting Block Class
public class MorphologyBlock : Block {
  
    int nCorsie;
    int nCarreggiate;

public enum TypeRoad { Straight, Curve, Roadbends, Highway };

public readonly TypeRoad typeRoad;
public TypeRoad _typeRoad{ get; set; }

  public int n_Corsie
    {
        get { 
               return nCorsie; 
            }
  
        set {
            if ((value >= 1) && (value <=2))
            {
                nCorsie= value;
            }           
       }
    }
    public void display_nCorsie()
    {
       Console.WriteLine("Corsie:" + n_Corsie+ " Carreggiate: "+ n_Carreggiate);
    }
    public int n_Carreggiate
    {
        get { 
               return nCarreggiate; 
            }
  
        set {
              if ((value >= 1) && (value <=3))
            {
                nCarreggiate= value;
            }   
            }
    }
}
// A derived class Cross
// inheriting MorphologyBlock Class
 public class Cross: MorphologyBlock
{
    
    public enum TypeCross{ None, TCross, Xcross, Roundabout, Immission};
    
    public readonly TypeCross typeCross;

    public TypeCross _typeCross{ get; set; }
    
}
// A derived class Rule
// inheriting Cross Class
public class Rule:Cross
{
    bool Stop;
    bool Priority;
    bool TrafficLight;

    
    public bool _stop
    {
        get { 
               return Stop; 
            }
  
        set {
             
                Stop= value;             
            }
    }
    public bool _priority
    {
        get { 
               return Priority; 
            }
  
        set {
             
                Priority= value;             
            }
    }
    public bool _trafficLight
    {
        get { 
               return TrafficLight; 
            }
  
        set {
             
                TrafficLight= value;             
            }
    }

    public enum IntensityTraffic{none, Medium, High};
    public readonly IntensityTraffic LevelOfTraffic;
    public IntensityTraffic _typeIntensityTraffic{ get; set; }
 
   // Constructor RuleBlock
    public Rule(int id_code, int n_Carreggiate, int n_Corsie, TypeRoad _typeRoad, 
    TypeCross _typeCross,IntensityTraffic _typeIntensityTraffic,bool _stop,
    bool Priority,bool _trafficLight)
    {
        // from Block class
        this.id_code= id_code;
          // from MorphologyBlock Class
         this.n_Carreggiate= n_Carreggiate;
         this.n_Corsie=n_Corsie;
         this._typeRoad=_typeRoad;
           // from Cross Class
         //-------------------
         this._typeCross=_typeCross;
           // from Rule Class
         //--------------------
         this._typeIntensityTraffic=_typeIntensityTraffic;
         this._stop=_stop;
         this._priority=_priority;
         this._trafficLight=_trafficLight;
        
    }  
}
  
// Driver Class
class CaratterizationBlock {
  
    // Main Method
    static void Main()
    {
        // Create and initialize the
        // object of Block

        Rule B1 = new Rule(01, 1, 1, MorphologyBlock.TypeRoad.Curve, Cross.TypeCross.TCross, Rule.IntensityTraffic.Medium, false, true, true);
        Rule B2 = new Rule(02, 2, 2, MorphologyBlock.TypeRoad.Straight, Cross.TypeCross.Roundabout, Rule.IntensityTraffic.none, true, true, false);

        //List
        List<Rule> RuleList = new List<Rule>();
         RuleList.Add(B1);
         RuleList.Add(B2);
      
        foreach (Rule Rule in RuleList)
        {
            Console.WriteLine($"Block: CODE: {Rule.id_code}| N.corsie: {Rule.n_Corsie}| dN.Carreggiate: {Rule.n_Carreggiate}| TypeRoad: {Rule._typeRoad}| TypeCross:{Rule._typeCross}| IntesityTrafficLevel none-medium-high: {Rule._typeIntensityTraffic}| Stop-T/F: {Rule._stop}| Priority-T/F: {Rule._priority}|do TrafficLight-T/F: {Rule._trafficLight}");
        }        
    }
}