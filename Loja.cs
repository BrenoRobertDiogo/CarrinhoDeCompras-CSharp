using System;
using System.Globalization;
using System.Collections.Generic;

class Loja {
  List<string> descricao = new List<string>{"10 COLOUR SPACEBOY PEN","SET/10 BLUE POLKADOT PARTY CANDLES","POTTING SHED SOW \'N\' GROW SET","PAPERWEIGHT KINGS CHOICE ","WOVEN BERRIES CUSHION COVER ","WHITE/PINK MINI CRYSTALS NECKLACE","SET/3 RED GINGHAM ROSE STORAGE BOX","MAGNETS PACK OF 4 VINTAGE LABELS ","WHITE CHRYSANTHEMUMS ART FLOWER","WHITE FRANGIPANI NECKLACE","SILVER FABRIC MIRROR","PINK  HONEYCOMB PAPER FAN","PINK BOUDOIR T-LIGHT HOLDER","BLACK CHERRY LIGHTS","GLASS CAKE COVER AND PLATE","DECORATION SITTING BUNNY","ANTIQUE MID BLUE FLOWER EARRINGS","VINTAGE LEAF CHOPPING BOARD  ","SNACK TRAY I LOVE LONDON","DECROTIVEVINTAGE COFFEE GRINDER BOX","IVORY ENCHANTED FOREST PLACEMAT","ANTIQUE SILVER TEA GLASS ETCHED","BLUE FELT HANGING HEART W FLOWER","PACK OF 12 COLOURED PENCILS","CLAM SHELL SMALL ","TWO DOOR CURIO CABINET","GREEN GOOSE FEATHER CHRISTMAS TREE ","MULTICOLOUR HONEYCOMB FAN","GREEN DROP EARRINGS W BEAD CLUSTER","BOTANICAL LILY GREETING CARD","SILVER DROP EARRINGS WITH FLOWER","CANDY SPOT BUNNY","WHITE WITH BLACK CATS PLATE","VEGETABLE MAGNETIC  SHOPPING LIST","FLOWER PURPLE CLOCK WITH SUCKER","VINTAGE CHRISTMAS GIFT SACK","found box","SET 10 CARDS SNOWY SNOWDROPS  17100","JUMBO SHOPPER VINTAGE RED PAISLEY","SET OF 4 ENGLISH ROSE PLACEMATS","FELTCRAFT HAIRBAND RED AND BLUE","BLUE GIANT GARDEN THERMOMETER","VINTAGE PAISLEY STATIONERY SET","SET OF 4 NAPKIN CHARMS CUTLERY","CARAVAN SQUARE TISSUE BOX","FRENCH PAISLEY CUSHION COVER ","GOLD FISHING GNOME","PINK BABY BUNTING","DROP DIAMANTE EARRINGS CRYSTAL","RED FLOCK LOVE HEART PHOTO FRAME"};
  public List<string> Descricao { get{return descricao;} set{ descricao = value; } }  
  // Quantidade
  List<int> quantidade = new List<int>{100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100};
  public List<int> Quantidade { get{ return quantidade;} set{ quantidade = value;} }
  
  List<double> preco = new List<double>{10.65,9.13,0.66,175.69,15.5,206.4,194.7,3.26,2019.05,109.19,404.49,157.08,183.2,124.87,888.42,736.38,0.84,0.07,2.4,24.96,9.72,160.0,18.62,14.75,2.82,10.2,29.74,19.96,80.46,183.09,152.19,49.13,8.0,138.46,135.08,2.41,10.82,425.14,2028.25,5.13,20.38,5.76,199.33,192.44,2.62,201.84,170.92,0.0,0.87,537.83};
  public List<double> Preco { get{ return preco; } set{ preco = value; } }

  // Aonde vai printar a tabela
  public void mostraTabela(){
    Console.WriteLine( Preco );
    for(int i=0; i<Preco.Count; i++){
      Console.WriteLine($"[{i}] | {Descricao[i]}");
    }

  }

  public string Titulo(){
    return @"-=-=-=-=-=-=-=-=-=-=
    Buy ON - #Proj2
-=-=-=-=-=-=-=-=-=-=";
  }

  public string Bot_e1() {
    return @"Olá! Eu sou o B-ON e estou aqui para te ajudar a fazer suas compras! Espero que esteja bem e seguro ;)";    
  }

  public string Bot_e2() {
    return @"Vamos começar com você me mandando seu nome completo e o seu CPF ta bom?!
Pressione ENTER após digitar o seu NOME e depois novamente após digitar seu CPF: ";
  }

  public string Bot_e3(){
    return @"
    Agora você pode escolher o seu produto e a quantidade que você quer.";
  }



}   