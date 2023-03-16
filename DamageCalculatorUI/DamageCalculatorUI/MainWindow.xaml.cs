using System;
using System.Diagnostics;
using System.Windows;

namespace DamageCalculatorUI
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private SwordDamage swordDamage = new SwordDamage();

        public MainWindow()
        {
            InitializeComponent();
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
            RollDice();
        }

        private void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage.SetFlaming(flaming.IsChecked.Value);
            swordDamage.SetMagic(magic.IsChecked.Value);
            DisplayDamage();
        }

        private void DisplayDamage()
        {
            damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
        }

        private void flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(true);
            DisplayDamage();
        }

        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(false);
            DisplayDamage();
        }

        private void magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(true);
            DisplayDamage();
        }

        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(false);
            DisplayDamage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
    }
}
