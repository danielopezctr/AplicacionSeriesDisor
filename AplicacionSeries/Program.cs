using System;
using AplicacionSeries.Controles;
using Dominio;
using Dominio.Interfaces;
using Gtk;

namespace AplicacionSeries
{
    class MainClass
    {
        const string ETIQUETA_FIBONACCI = "Numero fibonacci";
        const string ETIQUETA_SUERTE = "Numero de la suerte";
        const string ETIQUETA_PADOVAN = "Numero padovan";
        const string ETIQUETA_ULAM = "Numero ulam";

        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            
            AccionadorAvanzar acionadorAvanzar = new AccionadorAvanzar();
            AccionadorRetroceder acionadorRetroceder = new AccionadorRetroceder();

            PanelVertical panelPrincipal = new PanelVertical();
            PanelHorizontal panelBotones = new PanelHorizontal();

            CajaBinario NumeroFibonacciBinario = new CajaBinario();
            CajaHexadecimal NumeroFibonacciHexdecimal = new CajaHexadecimal();
            CajaDecimal NumeroFibonacciDecimal = new CajaDecimal();
            CajaEspañol NumeroFibonacciEspañol = new CajaEspañol();
            CajaBinario NumeroSuerteBinario = new CajaBinario();
            CajaHexadecimal NumeroSuerteHexdecimal = new CajaHexadecimal();
            CajaDecimal NumeroSuerteDecimal = new CajaDecimal();
            CajaEspañol NumeroSuerteEspañol = new CajaEspañol();
            CajaBinario NumeroPadovanBinario = new CajaBinario();
            CajaHexadecimal NumeroPadovanHexdecimal = new CajaHexadecimal();
            CajaDecimal NumeroPadovanDecimal = new CajaDecimal();
            CajaEspañol NumeroPadovanEspañol = new CajaEspañol();
            CajaBinario NumeroUlamBinario = new CajaBinario();
            CajaHexadecimal NumeroUlamnHexdecimal = new CajaHexadecimal();
            CajaDecimal NumeroUlamnDecimal = new CajaDecimal();
            CajaEspañol NumeroUlamEspañol = new CajaEspañol();

            Label etiquetaFibonacci = new Label(ETIQUETA_FIBONACCI);
            Label etiquetaSuerte = new Label(ETIQUETA_SUERTE);
            Label etiquetaPadovan = new Label(ETIQUETA_PADOVAN);
            Label etiquetaUlam = new Label(ETIQUETA_ULAM);

            var series = new ISerie[]
            {
                new NumeroFibonacci(),
                new NumeroSuerte(),
                new NumeroPadovan(),
                new NumeroUlam()
            };

            var cajas = new []
            {
                new ICajaTexto[]
                {
                    NumeroFibonacciBinario,
                    NumeroFibonacciHexdecimal,
                    NumeroFibonacciDecimal,
                    NumeroFibonacciEspañol
                },
                new ICajaTexto[]
                {
                    NumeroSuerteBinario,
                    NumeroSuerteHexdecimal,
                    NumeroSuerteDecimal,
                    NumeroSuerteEspañol
                },
                new ICajaTexto[]
                {
                    NumeroPadovanBinario,
                    NumeroPadovanHexdecimal,
                    NumeroPadovanDecimal,
                    NumeroPadovanEspañol
                },
                new ICajaTexto[]
                {
                    NumeroUlamBinario,
                    NumeroUlamnHexdecimal,
                    NumeroUlamnDecimal,
                    NumeroUlamEspañol
                }
            };

            Boton botonRetroceder = new Boton(acionadorRetroceder, series, cajas);

            Boton botonAvanzar = new Boton(acionadorAvanzar, series, cajas);

            panelBotones.AgregarControlHorizontal(botonRetroceder);
            panelBotones.AgregarControlHorizontal(botonAvanzar);

            panelPrincipal.AgregarControlVertical(panelBotones);
            panelPrincipal.AgregarControlVertical(etiquetaFibonacci);
            panelPrincipal.AgregarControlVertical(NumeroFibonacciBinario);
            panelPrincipal.AgregarControlVertical(NumeroFibonacciHexdecimal);
            panelPrincipal.AgregarControlVertical(NumeroFibonacciDecimal);
            panelPrincipal.AgregarControlVertical(NumeroFibonacciEspañol);
            panelPrincipal.AgregarControlVertical(etiquetaSuerte);
            panelPrincipal.AgregarControlVertical(NumeroSuerteBinario);
            panelPrincipal.AgregarControlVertical(NumeroSuerteHexdecimal);
            panelPrincipal.AgregarControlVertical(NumeroSuerteDecimal);
            panelPrincipal.AgregarControlVertical(NumeroSuerteEspañol);
            panelPrincipal.AgregarControlVertical(etiquetaPadovan);
            panelPrincipal.AgregarControlVertical(NumeroPadovanBinario);
            panelPrincipal.AgregarControlVertical(NumeroPadovanHexdecimal);
            panelPrincipal.AgregarControlVertical(NumeroPadovanDecimal);
            panelPrincipal.AgregarControlVertical(NumeroPadovanEspañol);
            panelPrincipal.AgregarControlVertical(etiquetaUlam);
            panelPrincipal.AgregarControlVertical(NumeroUlamBinario);
            panelPrincipal.AgregarControlVertical(NumeroUlamnHexdecimal);
            panelPrincipal.AgregarControlVertical(NumeroUlamnDecimal);
            panelPrincipal.AgregarControlVertical(NumeroUlamEspañol);
            win.Add(panelPrincipal);
            win.ShowAll();
            Application.Run();
        }
    }
}
