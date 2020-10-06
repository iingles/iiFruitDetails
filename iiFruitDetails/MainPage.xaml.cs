
//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 10/6/2020
//Project #: Participation 9
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iiFruitDetails
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Get the fruit name and display the color, type, and price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PckFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store the selected item in a string - parse the object into a string with ToString()

            // Check to make sure that there is an item selected or it will throw an error
            
            if (PckFruit.SelectedIndex != -1)
            {
                string fruit = PckFruit.SelectedItem.ToString();

                // Switch statment - test the value of the fruit string
                switch (fruit)
                {
                    case "Apple":
                        // Logic for apple
                        LblColor.Text = "Red";
                        LblPlantType.Text = "Tree";
                        LblPrice.Text = 1.99m.ToString("c");
                        DisplayAlert("Apple", "An apple a day...", "Close");
                        break;
                    case "Canteloupe":
                        // Logic for canteloupe
                        LblColor.Text = "Tan";
                        LblPlantType.Text = "Vine";
                        LblPrice.Text = 0.99m.ToString("c");
                        DisplayAlert("Canteloupe", "Cantelope is yummy.", "Close");
                        break;
                    case "Watermelon":
                        // Logic for watermelon
                        LblColor.Text = "Green";
                        LblPlantType.Text = "Vine";
                        LblPrice.Text = 0.69m.ToString("c");
                        DisplayAlert("Watermelon", "I love watermelon.", "Close");
                        break;
                    case "Peach":
                        // Logic for peach
                        LblColor.Text = "Peach";
                        LblPlantType.Text = "Tree";
                        LblPrice.Text = 2.99m.ToString("c");
                        DisplayAlert("Peach", "Peaches are gross..", "Close");
                        break;
                    default:
                        // Display an error alert as the default response
                        DisplayAlert("Error", "An error occured.", "Close");
                        break;
                }
            }            
                     
            
        }

        /// <summary>
        ///  Clear the labels/picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            // Reset the labels
            LblPrice.Text = "Results...";
            LblPlantType.Text = "Results...";
            LblColor.Text = "Results...";

            // Clear the picker by setting the index to -1
            PckFruit.SelectedIndex = -1;

        }


    }
}
