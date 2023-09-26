using ClosedXML.Excel;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class OtchetVM : Helper
    {
        private RelayCommand _otchettech;
        private RelayCommand _otchetfert;
        private RelayCommand _otchetcult;
        public RelayCommand OtchetFert => _otchetfert ??
                                      (_otchetfert = new RelayCommand((x) =>
                                      {
                                          ObservableCollection<Fertilizer> ferts = new(Service.Service.db.Fertilizers);
                                          XLWorkbook wb = new();
                                          string filename = "Exel".ToString();
                                          IXLWorksheet? ws = wb.Worksheets.Add("Otchet");
                                          ws.Columns("A").AdjustToContents(40);
                                          ws.Rows().AdjustToContents(20);
                                          
                                          ws.Cell(1, 1).Value = Convert.ToString("Название");
                                          ws.Cell(1, 2).Value = Convert.ToString("Дата производства");
                                          ws.Cell(1, 2).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                                          ws.Cell(1, 3).Value = Convert.ToString("Описание");
                                          ws.Cell(1, 4).Value = Convert.ToString("Цена");
                                          int xws = 1;
                                          int yws = 2;
                                          foreach (var item in ferts)
                                          {
                                              ws.Cell(yws, xws).Value = item.NameFertilizer;
                                              yws += 1;

                                          }
                                          xws = 2;
                                          yws = 2;
                                          foreach (var item in ferts)
                                          {
                                              ws.Cell(yws, xws).Value = item.DateManufacture.ToString();
                                              yws += 1;

                                          }
                                          xws = 3;
                                          yws = 2;
                                          foreach (var item in ferts)
                                          {
                                              ws.Cell(yws, xws).Value = item.DescriptionFertilizer;
                                              yws += 1;


                                          }
                                          xws = 4;
                                          yws = 2;
                                          foreach (var item in ferts)
                                          {
                                              ws.Cell(yws, xws).Value = item.PriceFert;
                                              yws += 1;
                                          }
                                          ws.Column("A").AdjustToContents();
                                          ws.Column("B").AdjustToContents();
                                          ws.Column("C").AdjustToContents();
                                          ws.Column("D").AdjustToContents();
                                          string path = null;
                                          VistaFolderBrowserDialog vfb = new VistaFolderBrowserDialog();
                                          vfb.ShowNewFolderButton = true;
                                          if (vfb.ShowDialog() == true)
                                          {
                                              path = vfb.SelectedPath;
                                          }
                                          if (path != null)
                                          {
                                              filename += "Otchet.xlsx";
                                              try
                                              {
                                                  wb.SaveAs($"{path}//{filename}");
                                              }
                                              catch (Exception e)
                                              {
                                                  MessageBox.Show("Не удается сохранить файл!");
                                                  return;
                                              }
                                          }
                                      }
                                      ));
        public RelayCommand OtchetTech => _otchettech ??
                                     (_otchetfert = new RelayCommand((x) =>
                                     {
                                         ObservableCollection<Technique> techs = new(Service.Service.db.Techniques);
                                         XLWorkbook wb = new();
                                         string filename = "Exel".ToString();
                                         IXLWorksheet? ws = wb.Worksheets.Add("Otchet");
                                         ws.Columns("A").AdjustToContents(40);
                                         ws.Rows().AdjustToContents(20);

                                         ws.Cell(1, 1).Value = Convert.ToString("Название");
                                         ws.Cell(1, 2).Value = Convert.ToString("Описание");
                                         ws.Cell(1, 2).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                                         ws.Cell(1, 3).Value = Convert.ToString("Модель");
                                         ws.Cell(1, 4).Value = Convert.ToString("Цена");
                                         int xws = 1;
                                         int yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.NameTechnique;
                                             yws += 1;

                                         }
                                         xws = 2;
                                         yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.DescriptionTechnique.ToString();
                                             yws += 1;

                                         }
                                         xws = 3;
                                         yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.Model;
                                             yws += 1;


                                         }
                                         xws = 4;
                                         yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.PriceTech;
                                             yws += 1;
                                         }
                                         ws.Column("A").AdjustToContents();
                                         ws.Column("B").AdjustToContents();
                                         ws.Column("C").AdjustToContents();
                                         ws.Column("D").AdjustToContents();
                                         string path = null;
                                         VistaFolderBrowserDialog vfb = new VistaFolderBrowserDialog();
                                         vfb.ShowNewFolderButton = true;
                                         if (vfb.ShowDialog() == true)
                                         {
                                             path = vfb.SelectedPath;
                                         }
                                         if (path != null)
                                         {
                                             filename += "Otchet.xlsx";
                                             try
                                             {
                                                 wb.SaveAs($"{path}//{filename}");
                                             }
                                             catch (Exception e)
                                             {
                                                 MessageBox.Show("Не удается сохранить файл!");
                                                 return;
                                             }
                                         }
                                     }
                                     ));
        public RelayCommand OtchetCult => _otchetcult ??
                                     (_otchetcult = new RelayCommand((x) =>
                                     {
                                         ObservableCollection<Culture> techs = new(Service.Service.db.Cultures);
                                         XLWorkbook wb = new();
                                         string filename = "Exel".ToString();
                                         IXLWorksheet? ws = wb.Worksheets.Add("Otchet");
                                         ws.Columns("A").AdjustToContents(40);
                                         ws.Rows().AdjustToContents(20);

                                         ws.Cell(1, 1).Value = Convert.ToString("Название");
                                         ws.Cell(1, 2).Value = Convert.ToString("Период созревания");
                                         ws.Cell(1, 2).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                                         ws.Cell(1, 3).Value = Convert.ToString("Описание растения");
                                         ws.Cell(1, 4).Value = Convert.ToString("Сезонность");
                                         int xws = 1;
                                         int yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.NameCulture;
                                             yws += 1;

                                         }
                                         xws = 2;
                                         yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.RipeningPeriod.ToString();
                                             yws += 1;

                                         }
                                         xws = 3;
                                         yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.DescriptionCulture;
                                             yws += 1;


                                         }
                                         xws = 4;
                                         yws = 2;
                                         foreach (var item in techs)
                                         {
                                             ws.Cell(yws, xws).Value = item.Seasonality;
                                             yws += 1;
                                         }
                                         ws.Column("A").AdjustToContents();
                                         ws.Column("B").AdjustToContents();
                                         ws.Column("C").AdjustToContents();
                                         ws.Column("D").AdjustToContents();
                                         string path = null;
                                         VistaFolderBrowserDialog vfb = new VistaFolderBrowserDialog();
                                         vfb.ShowNewFolderButton = true;
                                         if (vfb.ShowDialog() == true)
                                         {
                                             path = vfb.SelectedPath;
                                         }
                                         if (path != null)
                                         {
                                             filename += "Otchet.xlsx";
                                             try
                                             {
                                                 wb.SaveAs($"{path}//{filename}");
                                             }
                                             catch (Exception e)
                                             {
                                                 MessageBox.Show("Не удается сохранить файл!");
                                                 return;
                                             }
                                         }
                                     }
                                     ));
    }
}
