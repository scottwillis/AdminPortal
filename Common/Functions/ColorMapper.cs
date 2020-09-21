using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Common{
	public static class ColorMapper{

		public static Color GetColorForScalar(double normIntensity){
			//Input: Should be within the range [0,1].
			//Reference: http://www.andrewnoske.com/wiki/Code_-_heatmaps_and_color_gradients
			//Blue, green, yellow and red
			var setColors = new List<Color> { Color.FromArgb(0, 0, 255), Color.FromArgb(0, 255, 0), Color.FromArgb(255, 255, 0), Color.FromArgb(255, 0, 0) };

			int index1;
			int index2;
			double fracBetween = 0;

			if(normIntensity <= 0){
				index1 = 0;
				index2 = 0;
			}
			else if (normIntensity >= 1){
				index1 = setColors.Count - 1;
				index2 = setColors.Count - 1;
			}
			else{
				normIntensity = normIntensity * (setColors.Count - 1);
				index1 = Convert.ToInt32(Math.Floor(normIntensity));
				index2 = index1 + 1;
				fracBetween = normIntensity - index1;
			}

			var red = (Convert.ToDouble(setColors[index2].R.ToString()) - Convert.ToDouble(setColors[index1].R.ToString())) * fracBetween + Convert.ToDouble(setColors[index1].R.ToString());
			var green = (Convert.ToDouble(setColors[index2].G.ToString()) - Convert.ToDouble(setColors[index1].G.ToString())) * fracBetween + Convert.ToDouble(setColors[index1].G.ToString());
			var blue = (Convert.ToDouble(setColors[index2].B.ToString()) - Convert.ToDouble(setColors[index1].B.ToString())) * fracBetween + Convert.ToDouble(setColors[index1].B.ToString());

			return Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
		}

	}
}
