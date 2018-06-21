using System;
using System.Windows.Forms;

namespace Assign6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeN_Click(object sender, EventArgs e)
        {
            double PV;
            double calcPV;
            double interestRate;
            double newPaymentNum = 1;
            double oldPaymentNum;
            double difference;
            double diversity;
            double payment;
            double FV;
            int i = 0;

            if (Double.TryParse(PvTextBox.Text, out PV) && Double.TryParse(IyTextBox.Text, out interestRate) &&
               Double.TryParse(PmtTextBox.Text, out payment) && Double.TryParse(FvTextBox.Text, out FV))
            {
                if (interestRate >= 0)
                {
                    interestRate = interestRate / 100;
                    do
                    {
                        calcPV = FV * Math.Pow(1 + interestRate, -newPaymentNum);

                        if (interestRate == 0)
                        {
                            calcPV = calcPV + newPaymentNum * payment;
                        }
                        else
                        {
                            calcPV = calcPV + payment * ((1 - (Math.Pow(1 + interestRate, -newPaymentNum))) / interestRate);
                        }

                        calcPV = calcPV * -1;
                        // calculating the difference between the actual PV and the guess PV
                        difference = calcPV - PV;

                        Console.Write(difference + " ");
                        Console.Write(calcPV + " ");
                        Console.WriteLine(PV);

                        calcPV = FV * Math.Pow(1 + interestRate, -(newPaymentNum + 1));

                        if (interestRate == 0)
                        {
                            calcPV = calcPV + (newPaymentNum + 1) * payment;
                        }
                        else
                        {
                            calcPV = calcPV + payment * ((1 - (Math.Pow(1 + interestRate, -(newPaymentNum + 1)))) / interestRate);
                        }

                        calcPV = calcPV * -1;

                        // calculating the value we are going to change numer of payments by
                        diversity = calcPV - PV - difference;

                        // save the current guessed number of payments or periods  
                        oldPaymentNum = newPaymentNum;

                        // update the guessed number of payments 
                        newPaymentNum = newPaymentNum - difference / diversity;
                        i++;

                    } while (Math.Abs(difference) > 0.01 && i < 200);

                    if (i == 200)
                    {
                        NTextBox.Text = "Error.";
                    }
                    else
                    {
                        NTextBox.Text = String.Format("{0:0}", oldPaymentNum);
                        Output.Items.Add(String.Format("{0:0}", oldPaymentNum).PadRight(10) + interestRate.ToString().PadRight(10) + PV.ToString().PadRight(10) + payment.ToString().PadRight(10) + FV);
                    }
                }

                else
                {
                    MessageBox.Show("Interest rate cannot be a negative value.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please supply valid values.", "Error");
            }

        }
        private void ComputeFutureValue_Click(object sender, EventArgs e)
        {
            double PV;
            double interestRate;
            double paymentsNum;
            double payment;
            double FV;
            
            if (Double.TryParse(PvTextBox.Text, out PV) && Double.TryParse(IyTextBox.Text, out interestRate) && 
                Double.TryParse(PmtTextBox.Text, out payment) && Double.TryParse(NTextBox.Text, out paymentsNum) )
            {
                if (interestRate >= 0 && paymentsNum >= 0)
                {
                    // convert it to decimal 
                    interestRate = interestRate / 100;

                    // initail equation for future value
                    FV = PV * Math.Pow(1 + interestRate, paymentsNum);

                    // if there is no interest
                    if (interestRate == 0)
                    {
                        FV = FV + payment * paymentsNum;
                    }
                    else
                    {
                        FV = FV + payment * ((Math.Pow(1 + interestRate, paymentsNum) - 1) / interestRate);
                    }

                    FV = FV * -1; // swapping the signs 
                    FvTextBox.Text = String.Format("{0:0.00}", FV);
                }
                else
                {
                    MessageBox.Show("Interest rate and payment number cannot be negative.", "Error");
                }

            }
            else
            {
                MessageBox.Show("Please supply valid values.", "Error");
            }
        }

        private void ComputePayment_Click(object sender, EventArgs e)
        {
            double PV;
            double interestRate;
            double paymentsNum;
            double payment;
            double FV;

            if (Double.TryParse(PvTextBox.Text, out PV) && Double.TryParse(IyTextBox.Text, out interestRate) &&
                Double.TryParse(FvTextBox.Text, out FV) && Double.TryParse(NTextBox.Text, out paymentsNum))
            {
                if (interestRate >= 0 && paymentsNum >= 0)
                {
                    // convert it to decimal 
                    interestRate = interestRate / 100;

                    payment = (PV + ((PV + FV) / (Math.Pow(1 + interestRate, paymentsNum) - 1))) * interestRate;

                    payment = payment * -1;

                    PmtTextBox.Text = String.Format("{0:0.00}", payment);
                }
                else
                {
                    MessageBox.Show("Interest rate and payment number cannot be negative.", "Error");
                }

            }
            else
            {
                MessageBox.Show("Please supply valid values.", "Error");
            }


        }

        private void ComputePresentValue_Click(object sender, EventArgs e)
        {
            double PV;
            double interestRate;
            double paymentsNum;
            double payment;
            double FV;

            if (Double.TryParse(PmtTextBox.Text, out payment) && Double.TryParse(IyTextBox.Text, out interestRate) &&
                Double.TryParse(FvTextBox.Text, out FV) && Double.TryParse(NTextBox.Text, out paymentsNum))
            {
                if (interestRate >= 0 && paymentsNum >= 0)
                {
                    interestRate = interestRate / 100;
                    PV = FV * Math.Pow(1 + interestRate, -paymentsNum);

                    if (interestRate == 0)
                    {
                        PV = PV + paymentsNum * payment;
                    }
                    else
                    {
                        PV = PV + payment * ((1 - (Math.Pow(1 + interestRate, -paymentsNum))) / interestRate);
                    }

                    PV = PV * -1;
                    PvTextBox.Text = String.Format("{0:0.00}", PV);
                }
                else
                {
                    MessageBox.Show("Interest rate and payment number cannot be negative.", "Error");
                }

            }

            else
            {
                MessageBox.Show("Please supply valid values.", "Error");
            }

        }

        private void ComputeInterest_Click(object sender, EventArgs e)
        {
            double PV;
            double calcPV;
            double interestRate = 0.00001; // this is equal to 0.001%
            double interestRate2;
            double paymentNum;
            double difference;
            double diversity;
            double payment;
            double FV;
            double rateAdjust = 0.00001;
            int i = 0;

            if (Double.TryParse(PvTextBox.Text, out PV) && Double.TryParse(NTextBox.Text, out paymentNum) &&
               Double.TryParse(PmtTextBox.Text, out payment) && Double.TryParse(FvTextBox.Text, out FV))
            {
                if (paymentNum >= 0)
                {
                    do
                    {
                        calcPV = FV * Math.Pow(1 + interestRate, -paymentNum);

                        if (interestRate == 0)
                        {
                            calcPV = calcPV + paymentNum * payment;
                        }
                        else
                        {
                            calcPV = calcPV + payment * ((1 - (Math.Pow(1 + interestRate, -paymentNum))) / interestRate);
                        }
                        // switch the signs
                        calcPV = calcPV * -1;

                        // calculating the difference between the actual PV and the guess PV
                        difference = calcPV - PV;

                        calcPV = FV * Math.Pow(1 + (interestRate + rateAdjust), -paymentNum);

                        if (interestRate == 0)
                        {
                            calcPV = calcPV + paymentNum * payment;
                        }
                        else
                        {
                            calcPV = calcPV + payment * ((1 - (Math.Pow(1 + (interestRate + rateAdjust), -paymentNum))) / (interestRate + rateAdjust));
                        }

                        calcPV = calcPV * -1;

                        // calculating the value we are going to change numer of payments by
                        diversity = (calcPV - PV - difference) / rateAdjust;

                        // save the current interest rate 
                        interestRate2 = interestRate;

                        // update the guessed number of payments 
                        interestRate = interestRate - difference / diversity;
                        i++;

                    } while (Math.Abs(difference) > 0.01 && i < 200);

                    if (i == 200)
                    {
                        IyTextBox.Text = "Error.";
                    }
                    else
                    {
                        IyTextBox.Text = String.Format("{0:0.000}", interestRate2 * 100);
                    }
                }
                else
                {
                    MessageBox.Show("Payment number cannot be negative.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please supply valid values.", "Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NTextBox.Text = "0.00";
            IyTextBox.Text = "0.000";
            FvTextBox.Text = "0.00";
            PvTextBox.Text = "0.00";
            PmtTextBox.Text = "0.00";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }
    }
}
