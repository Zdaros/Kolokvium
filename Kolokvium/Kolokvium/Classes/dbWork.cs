using System;
using System.IO;
namespace Kolokvium.Classes
{
    public class dbWork
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;
        private SamplingData Sampl;
        private string FileContext;


        public string ReadFile() {
            string return_, line;
            return_ = "";
            while ((line = streamReader.ReadLine()) != null)
                return_ += line;
            
            return return_;
        }

        private void ReadSampl (int id,string GeomorphicBinding,
         string Date,
         float Gasoline,
         float CO2,
         float CO,
         float SO2,
         float HCI,
         string OblastName,
         string HumanSettlementName
         ) {

            Sampl.id = id;

            Sampl.SetCO2(CO2);
            Sampl.SetGasoline(Gasoline);
            Sampl.SetCO(CO);
            Sampl.SetHCI(HCI);
            Sampl.SetSO2(SO2);
            Sampl.SetGeomorphicBinding(GeomorphicBinding);
            Sampl.SetNameOfOblast(OblastName);
            Sampl.SetNameOfHS(HumanSettlementName);
            Sampl.SetDate(Date);
        }

        private void WriteFile(string ToWrite) {
            streamWriter.WriteLine(ToWrite);
        }

        public void Add(string GeomorphicBinding,
         string Date,
         float Gasoline,
         float CO2,
         float CO,
         float SO2,
         float HCI,
         string OblastName,
         string HumanSettlementName) {
            string line = "";
            int i = 0;
            while ((line = streamReader.ReadLine()) != null)
                i++;
            ReadSapml(i,GeomorphicBinding,Date,Gasoline,CO2,CO,SO2,HCI,OblastName,HumanSettlementName);
            string ToADD = Convert.ToString(Sampl.id) + Convert.ToString(Sampl.GetOblast()) + Convert.ToString(Sampl.GetGeomorphicBinding()) +Convert.ToString(Sampl.GetNameOfHS()) +Convert.ToString(Sampl.GetCO()) +Convert.ToString(Sampl.GetCO2()) +Convert.ToString(Sampl.GetHCI()) +Convert.ToString(Sampl.GetSO2()) +Convert.ToString(Sampl.GetDate()) +Convert.ToString(Sampl.GetGasoline());
            streamWriter.WriteLine(ToADD);
            FileContext = ReadFile();
        }
        public void Delete(int id) {
            string line = "", NewFileData = "";
            while ((line = streamReader.ReadLine()) != null)
                if (line[0] != Convert.ToChar(id))
                  NewFileData += line;
            WriteFile(NewFileData);
            FileContext = ReadFile();
        }

        public dbWork()
        {
            FileContext = "";
            streamReader = new StreamReader("../Table_matrix.txt");
            streamWriter = new StreamWriter("../Table_matrix.txt");
            FileContext = ReadFile();
            Sampl = new SamplingData();
        }
    }
}
