using System.Collections.Generic;

class Combobox : IDimensionavel, Iconfiguravel{
  
   private int MaxAlt;
  public int MaxAltura{
    get{
      return MaxAlt;
    } 
    set {
      MaxAlt = value;
    }      
  }
  private int MaxLarg;
  public int MaxLargura{
    get{
      return MaxLarg;
    }
    set{
      MaxLarg = value;
    }
  }
  private int AtualAlt;
  public int AtualAltura{
    get{
      return AtualAlt; 
    }
    set{
      AtualAlt = value;
    }
  }
  private int AtualLarg;
  public int AtualLargura{
    get{
      return AtualLarg;
    }
    set{
      AtualLarg = value;
    }
  }
  private List<string> opcoes;
  private int itemAtual;

  public void setItemAtual(int idx){
    itemAtual = idx;
  }

  public void FullScreen(){
    AtualAlt = MaxAlt;
    AtualLarg = MaxLarg;
  }
  //seta apenas a largura da modal. não pode dimensionar para menos de 1 e mais do que o possível
  public void setLargura(int larg){
    if (larg >= 1 && larg <= MaxLarg)
      AtualLarg = larg;
  }
  public void setAltura(int alt){
    if (alt >= 1 && alt <= MaxAlt)
      AtualAlt = alt;
  }

}