using System;
using System.Collections.Generic;
class Program {
  public static void Main (string[] args) {
    Janela minhaPopup = new Popup();
    Janela minhaModal = new Modal();
    //
    IDimensionavel minhaModal2 = new Modal();
    IDimensionavel minhaCombobox2 = new Combobox();

    List<IDimensionavel> meusComponentes = new List<IDimensionavel>{minhaModal2, minhaCombobox2};
    
  }
}