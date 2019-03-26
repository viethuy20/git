using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;


namespace QuanLyNhaSach
{
    class ExcelWrite : ExcelFileWriter<String>
    {
        public ExcelWrite(int rowNumber, int colNumber)
        {            
            this.rowNumber = rowNumber;
            this.colNumber = colNumber;
        }

        public ExcelWrite()
        {
            this.rowNumber = 0;
            this.colNumber = 0;
        }

        public object[,] myExcelData;
        
        private object[] _headers;
        public override object[] Headers
        {
            get 
            {
                return _headers;                
            }
            set
            {
                _headers = value;
            }
        }

        public override void FillRowData(List<String> list)
        {
            
            myExcelData = new object[RowCount + 1, ColumnCount];
            for (int row = 0; row < RowCount - 1; row++)
            {
                for (int col = 0; col < ColumnCount; col++)
                {
                    myExcelData[row, col] = list[row * ColumnCount + col];
                }
            }
        }

        public List<String> DGVToExcel(DataGridView dgv)
        {
            List<String> myList = new List<String>();

            //doc du lieu tu datagridview bo vao excel
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    myList.Add(dgv.Rows[i].Cells[j].Value.ToString());
                }
            }
            colNumber = dgv.ColumnCount;
            rowNumber = dgv.RowCount;            

            List<object> header = new List<object>();
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                header.Add(dgv.Columns[i].HeaderText);
            }
            Headers = new object[header.Count];
            header.CopyTo(Headers);

            return myList;
        }

        public override object[,] ExcelData
        {
            get
            {
                return myExcelData;
            }
        }
       
    }
}
