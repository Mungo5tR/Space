using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using VRageMath;
using VRage.Game;
using Sandbox.ModAPI.Interfaces;
using Sandbox.ModAPI.Ingame;
using Sandbox.Game.EntityComponents;
using VRage.Game.Components;
using VRage.Collections;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game.ModAPI.Ingame;
using SpaceEngineers.Game.ModAPI.Ingame;

namespace SpaceEngineers
{
    class Program : MyGridProgram
    {

        //
        // Alles zwischen diesem Kommentar ...
        //

        // Konstruktor, wird beim Programmstart/Neukompilieren ausgeführt
        public Program()
        {

        }

        // Mit der Funktion Save kann man Werte über die Spielsession hinweg speichern
        public void Save()

        {

        }

        // Die Hauptfunktion, diese wird vom Programmierbaren Block ausgeführt
        public void Main(string argument, UpdateType updateType)
        {

            //  Lautsprechererkennung

            var Laut = GridTerminalSystem.GetBlockWithName("Lautsprecherblock");
            if (Laut == null)
            {
                Echo("Lautsprecher nicht gefunden");
            }
            IMySoundBlock mySoundBlock = Laut as IMySoundBlock;

            //  Türenerfassung

            var doorIn = GridTerminalSystem.GetBlockWithName("SchlaeuseInnen");
            if (doorIn == null)
            {
                Echo("Innentür nicht gefunden");
                mySoundBlock.Play();
            }
            IMyDoor myDoorIn = doorIn as IMyDoor;

            var doorOut = GridTerminalSystem.GetBlockWithName("SchlaeuseAussen");
            if (doorOut == null)
            {
                Echo("Aussentür nicht gefunden");
            }
            IMyDoor myDoorOut = doorOut as IMyDoor;

            //  Lüftererfassung

            IMyAirVent myLuftschleuse = GridTerminalSystem.GetBlockWithName("Luftschleuse") as IMyAirVent;
            if (myLuftschleuse == null)
            {
                Echo("Luftschleuse nicht gefunden");
            }

            var airVent01 = GridTerminalSystem.GetBlockWithName("LüfterHalle01");
            if (airVent01 == null)
            {
                Echo("Lufter Halle 01 nicht gefunden");
            }
            IMyAirVent myLüfter01 = airVent01 as IMyAirVent;

            var airVent02 = GridTerminalSystem.GetBlockWithName("LüfterHalle02");
            if (airVent02 == null)
            {
                Echo("Lufter Halle 02 nicht gefunden");
            }
            IMyAirVent myLüfter02 = airVent02 as IMyAirVent;

            var airVent03 = GridTerminalSystem.GetBlockWithName("LüfterHalle03");
            if (airVent03 == null)
            {
                Echo("Lufter Halle 03 nicht gefunden");
            }
            IMyAirVent myLüfter03 = airVent03 as IMyAirVent;

            //-------------- Testbereich --------------------

            bool ventsPress = myLuftschleuse.GetValue<T>("PressurizationEnabled");

            if (ventsPress == true)
            {
                Echo("Schleuse hat Luft");
            }
            else { Echo("Schleuse hat keine Luft");
            }

            Echo("Schleuse Status =" + ventsPress);
            
            // neue zeile
        

        }


        //
        // ... und diesem muss in den Editor des programmierbaren Block kopiert werden
        //
    }
}