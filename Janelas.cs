class Janela {
  private bool BotaoFechar;
  private bool BotaoMax;
  private bool BotaoMin;
  private string Titulo;

  public void setTitulo(string t){
    Titulo = t;
  }

  private int PosX;
  private int PosY;

  public void MoverJanela(int x, int y){
    PosX = x;
    PosY = y;
  }



}