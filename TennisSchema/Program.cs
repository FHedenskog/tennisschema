using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchema
{
    public class Program
    {
        #region Field Region 

        static GroupManager GroupManager;

        #endregion

        #region Property Region

        #endregion

        public static void Main(string[] args)
        {
            List<SinglePlayer> players = new List<SinglePlayer>();
            List<DoublePair> doublePairs = new List<DoublePair>();

            SinglePlayer AnnikaDahlborn = new SinglePlayer("AnnikaDahlborn", true, true);
            SinglePlayer PiaHedenskog = new SinglePlayer("PiaHedenskog", true, true);
            SinglePlayer AnnaOdelius = new SinglePlayer("AnnaOdelius", true, true);
            SinglePlayer AnnePihl = new SinglePlayer("AnnePihl", true, true);
            SinglePlayer MartinaRustman = new SinglePlayer("MartinaRustman", true, true);
            SinglePlayer KristinaBlom = new SinglePlayer("KristinaBlom", true, true);
            SinglePlayer KarinEmtell = new SinglePlayer("KarinEmtell", true, true);
            SinglePlayer AnnlouiseUlfsparre = new SinglePlayer("Ann-LouiseUlfsparre", true, true);
            SinglePlayer CarinaKoch = new SinglePlayer("CarinaKoch", true, true);
            SinglePlayer ChristinaVonHoldt = new SinglePlayer("ChristinaVonHoldt", true, true);
            SinglePlayer EvaBrise = new SinglePlayer("EvaBrise", true, false);
            SinglePlayer HelenaSohlman = new SinglePlayer("HelenaSohlman", true, true);
            SinglePlayer AnetteBorneus = new SinglePlayer("AnetteBorneus", true, false);

            players.Add(AnnikaDahlborn);
            players.Add(PiaHedenskog);
            players.Add(AnnaOdelius);
            players.Add(AnnePihl);
            players.Add(MartinaRustman);
            players.Add(KristinaBlom);
            players.Add(KarinEmtell);
            players.Add(AnnlouiseUlfsparre);
            players.Add(CarinaKoch);
            players.Add(ChristinaVonHoldt);
            players.Add(EvaBrise);
            players.Add(HelenaSohlman);
            players.Add(AnetteBorneus);

            SinglePlayer CarolinaRamno = new SinglePlayer("CarolinaRamno", false, true);
            SinglePlayer MariaStrahle = new SinglePlayer("MariaStrahle", false, true);
            SinglePlayer AnnikaUnnebom = new SinglePlayer("AnnikaUnnebom", false, true);
            SinglePlayer HeleneRaneRoos = new SinglePlayer("HeleneRaneRoos", false, true);
            SinglePlayer AnnSofieHenriksson = new SinglePlayer("AnnSofieHenriksson", false, true);
            SinglePlayer AnnaSvensdotter = new SinglePlayer("AnnaSvensdotter", false, true);
            SinglePlayer LottaNordmark = new SinglePlayer("LottaNordmark", false, true);
            SinglePlayer AnnaFiskaare = new SinglePlayer("AnnaFiskaare", false, true);
            SinglePlayer HelenSvensson = new SinglePlayer("HelenSvensson", false, true);
            SinglePlayer NinaLindgren = new SinglePlayer("NinaLindgren", false, true);
            SinglePlayer KarinLinander = new SinglePlayer("KarinLinander", false, true);
            SinglePlayer SusanneTetlie = new SinglePlayer("SusanneTetlie", false, true);
            SinglePlayer AnnaMontgomery = new SinglePlayer("AnnaMontgomery", false, true);
            SinglePlayer MadeleineBondesson = new SinglePlayer("MadeleineBondesson", false, true);
            SinglePlayer MarikaOdman = new SinglePlayer("MarikaOdman", false, true);
            SinglePlayer SusannaJanefalk = new SinglePlayer("SusannaJanefalk", false, true);
            SinglePlayer KristinaNisell = new SinglePlayer("KristinaNisell", false, true);
            SinglePlayer MariaNygren = new SinglePlayer("MariaNygren", false, true);
            SinglePlayer BeritStenberg = new SinglePlayer("BeritStenberg", false, true);
            SinglePlayer BirgittaFlood = new SinglePlayer("BirgittaFlood", false, true);
            SinglePlayer AsaNeumann = new SinglePlayer("AsaNeumann", false, true);
            SinglePlayer LenaRojning = new SinglePlayer("LenaRojning", false, true);
            SinglePlayer MariaFolke = new SinglePlayer("MariaFolke", false, true);
            SinglePlayer KathrineHogseth = new SinglePlayer("KathrineHogseth", false, true);
            SinglePlayer SusanneHaegeland = new SinglePlayer("SusanneHaegeland", false, true);
            SinglePlayer LeniPhilip = new SinglePlayer("LeniPhilip", false, true);
            SinglePlayer JennyHellstrom = new SinglePlayer("JenniHellstrom", false, true);

            players.Add(CarolinaRamno);
            players.Add(MariaStrahle);
            players.Add(AnnikaUnnebom);
            players.Add(HeleneRaneRoos);
            players.Add(AnnSofieHenriksson);
            players.Add(AnnaSvensdotter);
            players.Add(LottaNordmark);
            players.Add(AnnaFiskaare);
            players.Add(HelenSvensson);
            players.Add(NinaLindgren);
            players.Add(KarinLinander);
            players.Add(SusanneTetlie);
            players.Add(AnnaMontgomery);
            players.Add(MadeleineBondesson);
            players.Add(MarikaOdman);
            players.Add(SusannaJanefalk);
            players.Add(KristinaNisell);
            players.Add(MariaNygren);
            players.Add(BeritStenberg);
            players.Add(BirgittaFlood);
            players.Add(AsaNeumann);
            players.Add(LenaRojning);
            players.Add(MariaFolke);
            players.Add(KathrineHogseth);
            players.Add(SusanneHaegeland);
            players.Add(LeniPhilip);
            players.Add(JennyHellstrom);

            doublePairs.Add(new DoublePair(AnnikaDahlborn.Name, AnnaOdelius.Name));
            doublePairs.Add(new DoublePair(AnnePihl.Name, CarolinaRamno.Name));
            doublePairs.Add(new DoublePair(MartinaRustman.Name, MariaStrahle.Name));
            doublePairs.Add(new DoublePair(PiaHedenskog.Name, AnnikaUnnebom.Name));
            doublePairs.Add(new DoublePair(HeleneRaneRoos.Name, AnnSofieHenriksson.Name));
            doublePairs.Add(new DoublePair(AnnaSvensdotter.Name, LottaNordmark.Name));
            doublePairs.Add(new DoublePair(KarinEmtell.Name, KristinaBlom.Name));
            doublePairs.Add(new DoublePair(AnnaFiskaare.Name, HelenSvensson.Name));
            doublePairs.Add(new DoublePair(NinaLindgren.Name, KarinLinander.Name));
            doublePairs.Add(new DoublePair(AnnlouiseUlfsparre.Name, SusanneTetlie.Name));
            doublePairs.Add(new DoublePair(AnnaMontgomery.Name, MadeleineBondesson.Name));
            doublePairs.Add(new DoublePair(MarikaOdman.Name, SusannaJanefalk.Name));
            doublePairs.Add(new DoublePair(KristinaNisell.Name, MariaNygren.Name));
            doublePairs.Add(new DoublePair(BeritStenberg.Name, BirgittaFlood.Name));
            doublePairs.Add(new DoublePair(AsaNeumann.Name, CarinaKoch.Name));
            doublePairs.Add(new DoublePair(LenaRojning.Name, HelenaSohlman.Name));
            doublePairs.Add(new DoublePair(ChristinaVonHoldt.Name, MariaFolke.Name));
            doublePairs.Add(new DoublePair(KathrineHogseth.Name, SusanneHaegeland.Name));
            doublePairs.Add(new DoublePair(LeniPhilip.Name, JennyHellstrom.Name));


            GroupManager = new GroupManager(players, doublePairs);



            Console.ReadKey();
        }
    }
}
