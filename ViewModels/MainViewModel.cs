using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace examen_Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        // Productos
        [ObservableProperty]
        private decimal producto1;

        [ObservableProperty]
        private decimal producto2;

        [ObservableProperty]
        private decimal producto3;

        // Subtotal, Descuento y Total
        [ObservableProperty]
        private decimal subtotal;

        [ObservableProperty]
        private decimal descuento;

        [ObservableProperty]
        private decimal totalPagar;

        // Comando para calcular
        [RelayCommand]
        public void Calcular()
        {
            Subtotal = Producto1 + Producto2 + Producto3;

            // Calcular el descuento según los rangos
            if (Subtotal >= 10000)
            {
                Descuento = 0.30m;
            }
            else if (Subtotal >= 5000)
            {
                Descuento = 0.20m;
            }
            else if (Subtotal >= 1000)
            {
                Descuento = 0.10m;
            }
            else
            {
                Descuento = 0.00m;
            }

            // Calcular el total a pagar
            TotalPagar = Subtotal - (Subtotal * Descuento);
        }

        // Comando para limpiar los campos
        [RelayCommand]
        public void Limpiar()
        {
            Producto1 = 0;
            Producto2 = 0;
            Producto3 = 0;
            Subtotal = 0;
            Descuento = 0;
            TotalPagar = 0;
        }
    }
}
