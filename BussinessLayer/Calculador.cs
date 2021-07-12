using System;

namespace BussinessLayer
{
    public class Calculador
    {
        public double Calcular(double MontoPrestamo, int CantidaddeCuotas, int TasadeInteres)
        {
            double CantidadFinal = 0;
            double Porciento, Interes;
            switch (TasadeInteres)
            {
                case (int)EnumTasa.PERSONAL:
                    switch (CantidaddeCuotas)
                    {
                        case (int)EnumMes.MES12:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 12;
                            break;
                        case (int)EnumMes.MES18:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 18;
                            break;
                        case (int)EnumMes.MES24:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 24;
                            break;
                        case (int)EnumMes.MES30:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 30;
                            break;
                        case (int)EnumMes.MES36:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 36;
                            break;
                        case (int)EnumMes.MES42:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 42;
                            break;
                        case (int)EnumMes.MES48:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 48;
                            break;
                        case (int)EnumMes.MES54:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 54;
                            break;
                        case (int)EnumMes.MES60:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 60;
                            break;
                        case (int)EnumMes.MES66:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 66;
                            break;
                        case (int)EnumMes.MES72:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 72;
                            break;
                        case (int)EnumMes.MES78:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 78;
                            break;
                        case (int)EnumMes.MES84:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 84;
                            break;
                        case (int)EnumMes.MES90:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 90;
                            break;
                        case (int)EnumMes.MES96:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 96;
                            break;
                        case (int)EnumMes.MES102:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 102;
                            break;
                        case (int)EnumMes.MES108:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 108;
                            break;
                        case (int)EnumMes.MES114:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 114;
                            break;
                        case (int)EnumMes.MES120:
                            Porciento = (MontoPrestamo * 22) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 120;
                            break;
                    }
                    break;
                
                
                case (int)EnumTasa.AUTOMOVIL:
                    switch (CantidaddeCuotas)
                    {
                        case (int)EnumMes.MES12:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 12;
                            break;
                        case (int)EnumMes.MES18:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 18;
                            break;
                        case (int)EnumMes.MES24:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 24;
                            break;
                        case (int)EnumMes.MES30:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 30;
                            break;
                        case (int)EnumMes.MES36:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 36;
                            break;
                        case (int)EnumMes.MES42:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 42;
                            break;
                        case (int)EnumMes.MES48:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 48;
                            break;
                        case (int)EnumMes.MES54:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 54;
                            break;
                        case (int)EnumMes.MES60:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 60;
                            break;
                        case (int)EnumMes.MES66:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 66;
                            break;
                        case (int)EnumMes.MES72:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 72;
                            break;
                        case (int)EnumMes.MES78:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 78;
                            break;
                        case (int)EnumMes.MES84:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 84;
                            break;
                        case (int)EnumMes.MES90:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 90;
                            break;
                        case (int)EnumMes.MES96:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 96;
                            break;
                        case (int)EnumMes.MES102:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 102;
                            break;
                        case (int)EnumMes.MES108:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 108;
                            break;
                        case (int)EnumMes.MES114:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 114;
                            break;
                        case (int)EnumMes.MES120:
                            Porciento = (MontoPrestamo * 12) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 120;
                            break;
                    }
                    break;
                
                
                case (int)EnumTasa.HIPOTECARIO:
                    switch (CantidaddeCuotas)
                    {
                        case (int)EnumMes.MES12:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 12;
                            break;
                        case (int)EnumMes.MES18:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 18;
                            break;
                        case (int)EnumMes.MES24:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 24;
                            break;
                        case (int)EnumMes.MES30:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 30;
                            break;
                        case (int)EnumMes.MES36:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 36;
                            break;
                        case (int)EnumMes.MES42:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 42;
                            break;
                        case (int)EnumMes.MES48:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 48;
                            break;
                        case (int)EnumMes.MES54:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 54;
                            break;
                        case (int)EnumMes.MES60:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 60;
                            break;
                        case (int)EnumMes.MES66:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 66;
                            break;
                        case (int)EnumMes.MES72:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 72;
                            break;
                        case (int)EnumMes.MES78:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 78;
                            break;
                        case (int)EnumMes.MES84:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 84;
                            break;
                        case (int)EnumMes.MES90:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 90;
                            break;
                        case (int)EnumMes.MES96:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 96;
                            break;
                        case (int)EnumMes.MES102:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 102;
                            break;
                        case (int)EnumMes.MES108:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 108;
                            break;
                        case (int)EnumMes.MES114:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 114;
                            break;
                        case (int)EnumMes.MES120:
                            Porciento = (MontoPrestamo * 8) / 100;
                            Interes = Porciento + MontoPrestamo;
                            CantidadFinal = Interes / 120;
                            break;
                    }
                    break;
            }
            return CantidadFinal;
        }
      
    }
}
