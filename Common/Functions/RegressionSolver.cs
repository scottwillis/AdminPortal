using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MathNet.Numerics.Integration;
using MathNet.Numerics.LinearAlgebra;

namespace Common {

	public class RegressionSolver {

		//Constructor
		public RegressionSolver() {
			xVals = new List<double>();
			yVals = new List<double>();
			modelCoeffs = new List<double>();
			dataPoints = new ObservableCollection<DataPoint>();
		}

		//Fields
		private List<double> xVals;
		private List<double> yVals;
		private List<double> modelCoeffs;
		private ObservableCollection<DataPoint> dataPoints; 


		//Properties
		public List<double> XVals { get { return xVals; } set { xVals = value; } }
		public List<double> YVals { get { return yVals; } set { yVals = value; } }
		//public List<DataPoint> DataPoints { get { return dataPoints; } } 
		public ObservableCollection<DataPoint> DataPoints { get { return dataPoints; } } 

		//Methods
		
		//Calculates the model coefficients based on the current lists of xVals and yVals
		//Stores model coefficients internally as well as returns to user as list
		public List<double> CalcModelCoeffs(int pOrder) {

			//Clears model coefficients -> ensures starting from clean slate
			modelCoeffs.Clear();


			//Test to always ensure that the pOrder that is being calculated is always at least 1 less than the qty. of data points
			if (xVals.Count <= pOrder) {
				//Decrement polynomial order until it is small enough for data set
				do {
					pOrder -= 1;
				} while (pOrder >= xVals.Count);
				//Console.WriteLine("Polynomial Order Reduced to: " + pOrder);
			}


			switch (pOrder) {
				
				//Case where the dependent variable is a constant
				case 0:
					modelCoeffs.Add(yVals.FirstOrDefault());
					return modelCoeffs;

				//Linear Regression Coefficients
				case 1:
					double[] bMatrix;
					bMatrix = new double[2];

					bMatrix[0] = yVals.Sum();
					bMatrix[1] = xVals.Zip(yVals, (first, second) => first * second).Sum();

					double[,] aMatrix = new double[2, 2];

					aMatrix[0, 0] = xVals.Count;
					aMatrix[0, 1] = xVals.Sum();
					aMatrix[1, 0] = xVals.Sum();
					aMatrix[1, 1] = xVals.Zip(xVals, (first, second) => first * second).Sum();

					//Build and create coefficient matrix with Math.NET Numerics
					var A = Matrix<double>.Build.DenseOfArray(aMatrix);
					//Console.Write(A.ToString());
					//Console.WriteLine("");

					//Build and create coefficient matrix with Math.NET Numerics
					var b = Vector<double>.Build.DenseOfArray(bMatrix);
					//Console.Write(b.ToString());
					//Console.WriteLine("");

					//Solve for solution coefficients
					modelCoeffs = new List<double>(A.Solve(b));

					return modelCoeffs;

				//Quadratic Regression Coefficients
				case 2:

					double[] bMatrix2;
					bMatrix2 = new double[3];

					bMatrix2[0] = yVals.Sum();
					bMatrix2[1] = xVals.Zip(yVals, (first, second) => first * second).Sum();
					bMatrix2[2] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 2) * second).Sum();

					double[,] aMatrix2 = new double[3, 3];

					aMatrix2[0, 0] = xVals.Count;
					aMatrix2[0, 1] = xVals.Sum();
					aMatrix2[0, 2] = xVals.Zip(xVals, (first, second) => first * second).Sum();
					aMatrix2[1, 0] = xVals.Sum();
					aMatrix2[1, 1] = xVals.Zip(xVals, (first, second) => first * second).Sum();
					aMatrix2[1, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix2[2, 0] = xVals.Zip(xVals, (first, second) => first * second).Sum();
					aMatrix2[2, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix2[2, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();

					//Build and create coefficient matrix with Math.NET Numerics
					var A2 = Matrix<double>.Build.DenseOfArray(aMatrix2);
					//Console.Write(A2.ToString());
					//Console.WriteLine("");

					//Build and create coefficient matrix with Math.NET Numerics
					var b2 = Vector<double>.Build.DenseOfArray(bMatrix2);
					//Console.Write(b2.ToString());
					//Console.WriteLine("");

					//Solve for solution coefficients
					modelCoeffs = new List<double>(A2.Solve(b2));

					return modelCoeffs;


				//3rd Order Polynomial Coefficients
				case 3:

					double[] bMatrix3;
					bMatrix3 = new double[4];

					bMatrix3[0] = yVals.Sum();
					bMatrix3[1] = xVals.Zip(yVals, (first, second) => first * second).Sum();
					bMatrix3[2] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 2) * second).Sum();
					bMatrix3[3] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 3) * second).Sum();

					double[,] aMatrix3 = new double[4, 4];
					aMatrix3[0, 0] = xVals.Count;
					aMatrix3[0, 1] = xVals.Sum();
					aMatrix3[0, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix3[0, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix3[1, 0] = xVals.Sum();
					aMatrix3[1, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix3[1, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix3[1, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix3[2, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix3[2, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix3[2, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix3[2, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix3[3, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix3[3, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix3[3, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix3[3, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();

					//Build and create coefficient matrix with Math.NET Numerics
					var A3 = Matrix<double>.Build.DenseOfArray(aMatrix3);
					//Console.Write(A3.ToString());
					//Console.WriteLine("");

					//Build and create coefficient matrix with Math.NET Numerics
					var b3 = Vector<double>.Build.DenseOfArray(bMatrix3);
					//Console.Write(b3.ToString());
					//Console.WriteLine("");

					//Solve for solution coefficients
					modelCoeffs = new List<double>(A3.Solve(b3));

					return modelCoeffs;


				//4th Order Polynomial Coefficients
				case 4:

					double[] bMatrix4;
					bMatrix4 = new double[5];

					bMatrix4[0] = yVals.Sum();
					bMatrix4[1] = xVals.Zip(yVals, (first, second) => first * second).Sum();
					bMatrix4[2] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 2) * second).Sum();
					bMatrix4[3] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 3) * second).Sum();
					bMatrix4[4] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 4) * second).Sum();

					double[,] aMatrix4 = new double[5, 5];
					aMatrix4[0, 0] = xVals.Count;
					aMatrix4[0, 1] = xVals.Sum();
					aMatrix4[0, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix4[0, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix4[0, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix4[1, 0] = xVals.Sum();
					aMatrix4[1, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix4[1, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix4[1, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix4[1, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix4[2, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix4[2, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix4[2, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix4[2, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix4[2, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix4[3, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix4[3, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix4[3, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix4[3, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix4[3, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 7)).Sum();
					aMatrix4[4, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix4[4, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix4[4, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix4[4, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 7)).Sum();
					aMatrix4[4, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 8)).Sum();

					//Build and create coefficient matrix with Math.NET Numerics
					var A4 = Matrix<double>.Build.DenseOfArray(aMatrix4);
					//Console.Write(A4.ToString());
					//Console.WriteLine("");

					//Build and create coefficient matrix with Math.NET Numerics
					var b4 = Vector<double>.Build.DenseOfArray(bMatrix4);
					//Console.Write(b4.ToString());
					//Console.WriteLine("");

					//Solve for solution coefficients
					modelCoeffs = new List<double>(A4.Solve(b4));

					return modelCoeffs;


				//5th Order Polynomial Coefficients
				case 5:

					double[] bMatrix5;
					bMatrix5 = new double[6];

					bMatrix5[0] = yVals.Sum();
					bMatrix5[1] = xVals.Zip(yVals, (first, second) => first * second).Sum();
					bMatrix5[2] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 2) * second).Sum();
					bMatrix5[3] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 3) * second).Sum();
					bMatrix5[4] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 4) * second).Sum();
					bMatrix5[5] = xVals.Zip(yVals, (first, second) => Math.Pow(first, 5) * second).Sum();

					double[,] aMatrix5 = new double[6, 6];

					aMatrix5[0, 0] = xVals.Count;
					aMatrix5[0, 1] = xVals.Sum();
					aMatrix5[0, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix5[0, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix5[0, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix5[0, 5] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix5[1, 0] = xVals.Sum();
					aMatrix5[1, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix5[1, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix5[1, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix5[1, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix5[1, 5] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix5[2, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 2)).Sum();
					aMatrix5[2, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix5[2, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix5[2, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix5[2, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix5[2, 5] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 7)).Sum();
					aMatrix5[3, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 3)).Sum();
					aMatrix5[3, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix5[3, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix5[3, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix5[3, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 7)).Sum();
					aMatrix5[3, 5] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 8)).Sum();
					aMatrix5[4, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 4)).Sum();
					aMatrix5[4, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix5[4, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix5[4, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 7)).Sum();
					aMatrix5[4, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 8)).Sum();
					aMatrix5[4, 5] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 9)).Sum();
					aMatrix5[5, 0] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 5)).Sum();
					aMatrix5[5, 1] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 6)).Sum();
					aMatrix5[5, 2] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 7)).Sum();
					aMatrix5[5, 3] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 8)).Sum();
					aMatrix5[5, 4] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 9)).Sum();
					aMatrix5[5, 5] = xVals.Zip(xVals, (first, second) => Math.Pow(first, 10)).Sum();

					//Build and create coefficient matrix with Math.NET Numerics
					var A5 = Matrix<double>.Build.DenseOfArray(aMatrix5);
					//Console.Write(A5.ToString());
					//Console.WriteLine("");

					//Build and create coefficient matrix with Math.NET Numerics
					var b5 = Vector<double>.Build.DenseOfArray(bMatrix5);
					//Console.Write(b5.ToString());
					//Console.WriteLine("");

					//Solve for solution coefficients
					modelCoeffs = new List<double>(A5.Solve(b5));

					return modelCoeffs;

				default:

					return null;


			}
		}

		//Calculates the dependent result based on the current lists of xVals, yVals, and modelCoeffs
		public double CalcResultVal(double drivingVal){

			switch (modelCoeffs.Count){
				//Case of a constant dependent variable
				case 1:
					return yVals.FirstOrDefault();
				//Linear Regression Model
				case 2:
					return modelCoeffs[0] + modelCoeffs[1]*drivingVal;
				//Quadratic Regression Model
				case 3:
					return modelCoeffs[0] + modelCoeffs[1]*drivingVal + modelCoeffs[2]*Math.Pow(drivingVal, 2);
				//3rd Order Polynomial
				case 4:
					return modelCoeffs[0] + modelCoeffs[1]*drivingVal + modelCoeffs[2]*Math.Pow(drivingVal, 2) + modelCoeffs[3]*Math.Pow(drivingVal, 3);
				//4th Order Polynomial
				case 5:
					return modelCoeffs[0] + modelCoeffs[1]*drivingVal + modelCoeffs[2]*Math.Pow(drivingVal, 2) +modelCoeffs[3]*Math.Pow(drivingVal, 3) + modelCoeffs[4]*Math.Pow(drivingVal, 4);
				//5th Order Polynomial
				case 6:
					return modelCoeffs[0] + modelCoeffs[1] * drivingVal + modelCoeffs[2] * Math.Pow(drivingVal, 2) + modelCoeffs[3] * Math.Pow(drivingVal, 3) + modelCoeffs[4] * Math.Pow(drivingVal, 4) + modelCoeffs[5]*Math.Pow(drivingVal,5);
				default:
					return -1;
			}


		}

		//Calculates the coefficient of determination (R^2) value for the current model
		public double CalcRSquared(int pOrder)
		{
			var yValMean = YVals.Average();

			double totalSumSquares = yVals.Sum(val => Math.Pow((val - yValMean), 2));

			var modelCoeffsRSquared = CalcModelCoeffs(pOrder);

			List<double> calculatedYVals = xVals.Select(x => CalcResultVal(x)).ToList();

			double residualSumSquares = 0;

			for (var i = 0; i < yVals.Count; i++)
			{
				residualSumSquares += Math.Pow((YVals[i] - calculatedYVals[i]), 2);
			}

			var resultVal = 1- residualSumSquares/totalSumSquares;

			return resultVal >= 0 ? resultVal : 0;
		}
        
		//Creates DataPoint objects from the stored xVals and yVals list
		public ObservableCollection<Common.DataPoint> CreateDataPoints() {
			//Clear list
			dataPoints.Clear();
			//Populate list
			for (int i = 0; i < XVals.Count; i++) {
				var point = new DataPoint();
				point.XValue = XVals[i];
				point.YValue = YVals[i];
				dataPoints.Add(point);
			}
			return dataPoints;
		}

		//Creates DataPoint objects from the trendline/regression model
		public ObservableCollection<Common.DataPoint> CreateRegressionModelDataPoints(Int32 polyOrder)
		{
			//Recalculate model coefficients to ensure correct regression model
			CalcModelCoeffs(polyOrder);

			if (polyOrder + 1 != modelCoeffs.Count) return null;
			
			//Determine qty. of returned data points -> Target: 100 data points
			var maxXVal = XVals.Max();
			var minXVal = XVals.Min();

			Int32 dataPointQty = 100;

			var stepSize = (maxXVal - minXVal)/dataPointQty;

			//Create collection to return
			ObservableCollection<DataPoint> calcDataPoints = new ObservableCollection<DataPoint>();

			switch (modelCoeffs.Count)
			{
				//Case of a constant dependent variable
				case 1:
					if (XVals.Count >= 1)
					{
						for (int i = 0; i <= dataPointQty; i++)
						{
							var point = new DataPoint
							            {
								            XValue = minXVal + stepSize*i,
								            YValue = YVals.FirstOrDefault()
							            };

							calcDataPoints.Add(point);
						}
						return calcDataPoints;
					}
					return null;


				//Linear regression model
				case 2:
					if (XVals.Count >= 2)
					{
						for (int i = 0; i <= dataPointQty; i++) {
							var point = new DataPoint();
							point.XValue = minXVal + stepSize * i;
							point.YValue = modelCoeffs[0] + modelCoeffs[1] * point.XValue;
							calcDataPoints.Add(point);
						}
						return calcDataPoints;
					}
					return null;
					
				//Quadratic Regression Model
				case 3:
					if (XVals.Count >= 3)
					{
						for (int i = 0; i <= dataPointQty; i++) {
							var point = new DataPoint();
							point.XValue = minXVal + stepSize * i;
							point.YValue = modelCoeffs[0] + modelCoeffs[1] * point.XValue + modelCoeffs[2] * Math.Pow(point.XValue, 2);
							calcDataPoints.Add(point);
						}
						return calcDataPoints;
					}
					return null;
					
				//3rd Order Polynomial
				case 4:
					if (XVals.Count >= 4)
					{
						for (int i = 0; i <= dataPointQty; i++) {
							var point = new DataPoint();
							point.XValue = minXVal + stepSize * i;
							point.YValue = modelCoeffs[0] + modelCoeffs[1] * point.XValue + modelCoeffs[2] * Math.Pow(point.XValue, 2) + modelCoeffs[3] * Math.Pow(point.XValue, 3);
							calcDataPoints.Add(point);
						}
						return calcDataPoints;
					}
					return null;
					
				//4th Order Polynomial
				case 5:
					if (XVals.Count >= 5)
					{
						for (int i = 0; i <= dataPointQty; i++) {
							var point = new DataPoint();
							point.XValue = minXVal + stepSize * i;
							point.YValue = modelCoeffs[0] + modelCoeffs[1] * point.XValue + modelCoeffs[2] * Math.Pow(point.XValue, 2) + modelCoeffs[3] * Math.Pow(point.XValue, 3) + modelCoeffs[4] * Math.Pow(point.XValue, 4);
							calcDataPoints.Add(point);
						}
						return calcDataPoints;
					}
					return null;
					
				//5th Order Polynomial
				case 6:
					if (XVals.Count >= 6)
					{
						for (int i = 0; i <= dataPointQty; i++) {
							var point = new DataPoint();
							point.XValue = minXVal + stepSize * i;
							point.YValue = modelCoeffs[0] + modelCoeffs[1] * point.XValue + modelCoeffs[2] * Math.Pow(point.XValue, 2) + modelCoeffs[3] * Math.Pow(point.XValue, 3) + modelCoeffs[4] * Math.Pow(point.XValue, 4) + modelCoeffs[5] * Math.Pow(point.XValue, 5);
							calcDataPoints.Add(point);
						}
						return calcDataPoints;
					}
					return null;
			}

			return null;

		} 

        //Calculates the model coefficients (logarithmic) based on the current lists of xVals and yVals
		//Stores model coefficients internally as well as returns to user as list
        //Source: http://mathworld.wolfram.com/LeastSquaresFittingLogarithmic.html        
        public List<double> CalcLogModelCoeffs() {

            modelCoeffs.Clear();
            if(xVals.Count != 0 && yVals.Count != 0) {
                var n = xVals.Count;

                double yLnXSum = 0;
                double lnXSum = 0;
                double lnXSumSquared = 0;
                for (int i = 0; i < xVals.Count; i++) {
                    yLnXSum += yVals[i] * Math.Log(xVals[i]);
                    lnXSum += Math.Log(xVals[i]);
                    lnXSumSquared += Math.Pow(Math.Log(xVals[i]), 2);
                }

                var b = (n * yLnXSum - yVals.Sum() * lnXSum) / (n * lnXSumSquared - Math.Pow(lnXSum, 2));

                var a = (yVals.Sum() - b * lnXSum) / n;

                modelCoeffs.Add(a);
                modelCoeffs.Add(b);

                return modelCoeffs;

            }
            else {
                return null;
            }
        }
        public double CalcLogResultVal(double drivingVal) {
            if(drivingVal > 0) {
                return modelCoeffs[0] + modelCoeffs[1] * Math.Log(drivingVal);
            }
            //Error if code reaches here
            return 0;
        }
        public double CalcLogRSquared() {

            var yValMean = YVals.Average();

			double totalSumSquares = yVals.Sum(val => Math.Pow((val - yValMean), 2));

            //var modelCoeffsRSquared = CalcModelCoeffs(pOrder);
            var modelCoeffsRSquared = CalcLogModelCoeffs();
            
			//List<double> calculatedYVals = xVals.Select(x => CalcResultVal(x)).ToList();
            List<double> calculatedYVals = xVals.Select(x => CalcLogResultVal(x)).ToList();

			double residualSumSquares = 0;

			for (var i = 0; i < yVals.Count; i++)
			{
				residualSumSquares += Math.Pow((YVals[i] - calculatedYVals[i]), 2);
			}

			var resultVal = 1- residualSumSquares/totalSumSquares;

			return resultVal >= 0 ? resultVal : 0;
        }

        //Calculates the model coefficients (exponential) based on the current lists of xVals and yVals
		//Stores model coefficients internally as well as returns to user as list
        //Source: http://mathworld.wolfram.com/LeastSquaresFittingExponential.html#eqn9
        public List<double> CalcExpModelCoeffs() {

            modelCoeffs.Clear();
            if(xVals.Count != 0 && yVals.Count != 0) {

                double xSquaredYSum = 0;
                double yLnYSum = 0;
                double xProductYSum = 0;
                double xProductYLnYSum = 0;
                
                for (int i = 0; i < xVals.Count; i++) {
                    xSquaredYSum += Math.Pow(xVals[i], 2) * yVals[i];
                    yLnYSum += yVals[i] * Math.Log(yVals[i]);
                    xProductYSum += xVals[i] * yVals[i];
                    xProductYLnYSum += xVals[i] * yVals[i] * Math.Log(yVals[i]);
                }


                var a = (xSquaredYSum * yLnYSum - xProductYSum * xProductYLnYSum) / (yVals.Sum() * xSquaredYSum - Math.Pow(xProductYSum, 2));

                var b = (yVals.Sum() * xProductYLnYSum - xProductYSum * yLnYSum) / (yVals.Sum() * xSquaredYSum - Math.Pow(xProductYSum, 2));

                modelCoeffs.Add(Math.Exp(a));
                modelCoeffs.Add(b);

                return modelCoeffs;

            }

            //Error if code reaches to here
            return null;

        }

        public double CalcExpResultVal(double drivingVal) {
            return modelCoeffs[0] * Math.Exp(modelCoeffs[1] * drivingVal); 
        }

        public double CalcExpRSquared() {

            var yValMean = YVals.Average();

						double totalSumSquares = yVals.Sum(val => Math.Pow((val - yValMean), 2));

            //var modelCoeffsRSquared = CalcModelCoeffs(pOrder);
            //var modelCoeffsRSquared = CalcLogModelCoeffs();
            var modelCoeffsRSquared = CalcExpModelCoeffs();
            
						//List<double> calculatedYVals = xVals.Select(x => CalcResultVal(x)).ToList();
            //List<double> calculatedYVals = xVals.Select(x => CalcLogResultVal(x)).ToList();
            List<double> calculatedYVals = xVals.Select(x => CalcExpResultVal(x)).ToList();

						double residualSumSquares = 0;

						for (var i = 0; i < yVals.Count; i++)
						{
							residualSumSquares += Math.Pow((YVals[i] - calculatedYVals[i]), 2);
						}

						var resultVal = 1- residualSumSquares/totalSumSquares;

						return resultVal >= 0 ? resultVal : 0;
        }

        //Calculates the model coefficients (power law) based on the current lists of xVals and yVals
		//Stores model coefficients internally as well as returns to user as list
        //Source: http://mathworld.wolfram.com/LeastSquaresFittingPowerLaw.html
        public List<double> CalcPowerModelCoeffs() {

            modelCoeffs.Clear();
            if(xVals.Count != 0 && yVals.Count != 0) {

                var n = xVals.Count();

                double lnXProductLnYSum = 0;
                double lnXSum = 0;
                double lnYSum = 0;
                double lnXSquaredSum = 0;

                for (int i = 0; i < xVals.Count; i++) {
                    lnXProductLnYSum += Math.Log(xVals[i]) * Math.Log(yVals[i]);
                    lnXSum += Math.Log(xVals[i]);
                    lnYSum += Math.Log(yVals[i]);
                    lnXSquaredSum += Math.Pow(Math.Log(xVals[i]), 2);
                }

                var b = (n * lnXProductLnYSum - lnXSum * lnYSum) / (n * lnXSquaredSum - Math.Pow(lnXSum, 2));

                var a = (lnYSum - b * lnXSum) / n;

                modelCoeffs.Add(Math.Exp(a));
                modelCoeffs.Add(b);
                
                return modelCoeffs;

            }

            //Error if code reaches to here
            return null;

        }
        public double CalcPowerResultVal(double drivingVal){
	        if (modelCoeffs.Count < 2) return -1;
            return modelCoeffs[0] * Math.Pow(drivingVal, modelCoeffs[1]);
        }

        public double CalcPowerResultVal(double drivingVal, double modelCoeff_Product, double modelCoeff_Exponent) {
            return modelCoeff_Product * Math.Pow(drivingVal, modelCoeff_Exponent);
        }
        
        public double CalcPowerRSquared() {

            if (YVals.Count != 0) {

                var yValMean = YVals.Average();

                double totalSumSquares = yVals.Sum(val => Math.Pow((val - yValMean), 2));

                //var modelCoeffsRSquared = CalcModelCoeffs(pOrder);
                //var modelCoeffsRSquared = CalcLogModelCoeffs();
                //var modelCoeffsRSquared = CalcExpModelCoeffs();
                var modelCoeffsRSquared = CalcPowerModelCoeffs();

                //List<double> calculatedYVals = xVals.Select(x => CalcResultVal(x)).ToList();
                //List<double> calculatedYVals = xVals.Select(x => CalcLogResultVal(x)).ToList();
                //List<double> calculatedYVals = xVals.Select(x => CalcExpResultVal(x)).ToList();
                List<double> calculatedYVals = xVals.Select(x => CalcPowerResultVal(x)).ToList();

                double residualSumSquares = 0;

                for (var i = 0; i < yVals.Count; i++) {
                    residualSumSquares += Math.Pow((YVals[i] - calculatedYVals[i]), 2);
                }

                var resultVal = 1 - residualSumSquares / totalSumSquares;

                return resultVal >= 0 ? resultVal : 0;

            }
            return 0;

        }


	}

	public class DataPoint
	{
		//Constructor
		public DataPoint()
		{
			
		}
	
		//Fields
		private Double xValue;
		private Double yValue;

		//Properties
		public Double XValue { get { return xValue; } set { xValue = value; } }
		public Double YValue { get { return yValue; } set { yValue = value; } }
	}
}