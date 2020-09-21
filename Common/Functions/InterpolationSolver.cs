using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
	public class InterpolationSolver {
		/// <summary>
		// Class to perform linear and polynomial based interpolation.
		// Ref: https://en.wikipedia.org/wiki/Polynomial_interpolation
		/// </summary>

		public InterpolationSolver() {
			PolyModelCoeffs = new List<double>();
		}

		private List<double> PolyModelCoeffs { get; set; }

		public double LinearInterpolate(double x_1, double y_1, double x_3, double y_3, double x_2) {
			//Known Points: (x_1, y_1) and (x_3, y_3).  Estimate is for middle point (x_2, y_2).  
			return y_1 + ((y_3 - y_1) / (x_3 - x_1)) * (x_2 - x_1);
		}

		public void CalcPolyModelCoeffs(List<DataPoint> dataPoints) {
			PolyModelCoeffs.Clear();
			if (dataPoints.Count <= 1) return;

			var matrixSize = dataPoints.Count;

			double[,] aMatrix = new double[matrixSize, matrixSize]; //Vandermode Matrix - Transposed??
			for (int j = 0; j < matrixSize; j++) {
				for (int i = 0; i < matrixSize; i++) {
					if(i == matrixSize - 1) {
						aMatrix[i, j] = 1;
						continue;
					}
					aMatrix[i, j] = Math.Pow(dataPoints[j].XValue	, matrixSize-1 - i);
				}
			}

			double[] bVector = new double[matrixSize];
			for (int k = 0; k < dataPoints.Count; k++) {
				bVector[k] = dataPoints[k].YValue;
			}

			var A = Matrix<double>.Build.DenseOfArray(aMatrix);
			var b = Vector<double>.Build.DenseOfArray(bVector);

			PolyModelCoeffs = new List<double>(A.Transpose().Solve(b));
		}

		public double PolyInterpolate(double x, out bool result, List<DataPoint> dataPoints = null) {
			result = true;
			if (dataPoints != null) CalcPolyModelCoeffs(dataPoints);
			if(PolyModelCoeffs.Count == 0) {
				result = false;
				return 0;
			}

			var interpolateResult = 0.0;

			for (int i = 0; i < PolyModelCoeffs.Count; i++) {
				interpolateResult += PolyModelCoeffs[i] * Math.Pow(x, PolyModelCoeffs.Count -1-i);
			}

			return interpolateResult;
		}


	}
}
