﻿using AspnetMvcDemo.Models;
using AspnetMvcDemo.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcDemo.Controllers
{
    public class ConcreteFactoryReportsController : Controller
    {
        QCEntities db = new QCEntities();

        // GET: ConcreteFactoryReports
        public ActionResult ConcreteFactoryReports(int id)
        {
            var factory = db.Factory11.Where(f => f.Id == id).FirstOrDefault();
            var samples = db.ConcreteSample1.OrderByDescending(s => s.ReportNo).ToList();
            var lastSample = samples.Count() == 0 ? null : samples.FirstOrDefault();

            ConcreteSamplesWithPath sample = new ConcreteSamplesWithPath();
            //sample.FactoryId = factory.Id;
            sample.SampleNumber = lastSample == null ? 5001 : lastSample.SampleNumber + 1;
            sample.ReportNo = lastSample == null ? 6001 : lastSample.ReportNo + 1;
            sample.VisitNumber = lastSample == null ? 3001 : lastSample.VisitNumber + 1;
            sample.FactoryName = factory.Name;
            sample.FactoryLocation = factory.Location;
            //sample.ClientName = factory.OwnerName;
            return View(sample);
        }

        [HttpGet]
        public ActionResult CancleFactoryReport(string id)
        {
            int factid = int.Parse(id);
            VisitDetail visitDetail = db.VisitDetails.Where(v => v.FactoryId == factid && v.VisitDate == DateTime.Today).FirstOrDefault();
            return View(visitDetail);
        }

        [HttpPost]
        public ActionResult CancleFactoryReport(VisitDetail visitDetail)
        {
            VisitService visitService = new VisitService();
            var result = visitService.CancleVisit(visitDetail);
            if (result == true)
                return RedirectToAction("Home", "Home", new { id = 1 });
            else
                return RedirectToAction("ConcreteFactoryReports", "ConcreteFactoryReports", new { id = visitDetail.FactoryId });
        }
 

        [HttpPost]
        public ActionResult AddConcreteSample(ConcreteSamplesWithPath sample)
        {
            ObjectParameter statusCode = new ObjectParameter("StatusCode", typeof(int));
            ObjectParameter statusMessage = new ObjectParameter("StatusMessage", typeof(string));


            if (sample.ConcreteTemperture >= 34 || sample.DownAmount <= 100)
            {
                bool Flag = false;
                Infraction infra = db.Infractions.Where(s => s.SampleNo == sample.SampleNumber).FirstOrDefault();
                if (infra == null)
                {
                    Flag = true;
                    infra = new Infraction();
                    infra.AdminApproved = false;
                    infra.MonitorApproved = false;
                    infra.VisitDate = DateTime.Now;

                }
                //infra.FactoryId = sample.FactoryId;
                infra.SampleNo = sample.SampleNumber;
                if (sample.ConcreteTemperture >= 34)
                    infra.Temperature = true;
                if (sample.DownAmount <= 100)
                    infra.Landing = true;
                if (sample.IsCleanLocation == false)
                    infra.IsCleanLocation = false;
                if (Flag == true)
                db.Infractions.Add(infra);
                db.SaveChanges();
            }

            foreach (var file in sample.files)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);
                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.InvoicePhoto = InputFileName + fi.Extension;
                }
            }
            foreach (var file in sample.CleanDocfiles)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);

                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.CleanDocPath = InputFileName + fi.Extension;
                }
            }
            foreach (var file in sample.DustDocfiles)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);
                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.DustDocPath = InputFileName + fi.Extension;
                }
            }
            foreach (var file in sample.LabDocfiles)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);
                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.LabDocPath = InputFileName + fi.Extension;
                }
            }
            foreach (var file in sample.SafteyDocfiles)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);
                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.SafteyDocPath = InputFileName + fi.Extension;
                }
            }
            foreach (var file in sample.SummerDocfiles)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);
                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.SummerDocPath = InputFileName + fi.Extension;
                }
            }
            foreach (var file in sample.TruckDocfiles)
            {
                if (file != null)
                {
                    Random random = new Random();
                    FileInfo fi = new FileInfo(file.FileName);
                    DateTime d = DateTime.Now;
                    var InputFileName = d.Ticks + random.Next(100, 100000000).ToString();
                    var ServerSavePath = System.IO.Path.Combine(Server.MapPath("~/Content"), InputFileName + fi.Extension);
                    //Save file to server folder  
                    file.SaveAs(ServerSavePath);
                    sample.TruckDocPath = InputFileName + fi.Extension;
                }
            }
            if (sample.Reason1 == null)
                sample.OtherReason = sample.Reason2;
            else
                sample.OtherReason = sample.Reason1;

            var uId = Convert.ToInt32(Session["UserId"].ToString());
            db.AddUpdateConcreteSample(sample.ReportNo, sample.ReportDate, sample.FactoryName, sample.FactoryLocation, sample.MixerNumber, sample.VisitNumber,
                                       sample.SampleNumber, sample.TruckNumber, sample.InvoiceNumber, sample.ClientName, sample.VisitLocation, sample.Latitude,
                                       sample.Longitude, sample.ConcreteRank, sample.ConcreteTemperture, sample.WaterTemperature, sample.WeatherTemperture,
                                       sample.DownAmount, sample.CementType, sample.CementSource, sample.AdditionType, sample.AdditionAmount, sample.CementWeight,
                                       sample.WaterWieght, sample.WashedSandWeight, sample.WhiteSandWeight, sample.Rubble3by4, sample.Rubble3by8, sample.IsCleanUsage,
                                       sample.IsBasicUsage, sample.IsColumnUsage, sample.IsRoofUsage, sample.IsOtherUsage, sample.IsCleanLocation, sample.CleanDocPath,
                                       sample.IsDustControlInStation, sample.DustDocPath, sample.IsRokamSummer, sample.SummerDocPath, sample.IsLabEngineer, sample.LabDocPath,
                                       sample.IsMoldanatInTrucks, sample.TruckDocPath, sample.IsPeopleSafty, sample.SafteyDocPath, uId, null, statusCode, statusMessage,sample.InvoicePhoto
                                      ,sample.CleanDocNote , sample.DustDocNote, sample.SummerDocNote,sample.LabDocNote, sample.TruckDocNote, sample.SafteyDocNote ,sample.OtherReason);

            TempData["AlertMessage1"] = "Success";
            return RedirectToAction("Home","Home", new { Id=1});
        }

        public ActionResult UpdateConcreteReport(int id)
        {
            ObjectParameter statusCode = new ObjectParameter("StatusCode", typeof(int));
            ObjectParameter statusMessage = new ObjectParameter("StatusMessage", typeof(string));

            var userId = Convert.ToInt32(Session["UserId"].ToString());

            var factoryName = db.Factory11.Where(f => f.Id == id).Select(x => x.Name).FirstOrDefault();

            var sampleNumber = from s in db.ConcreteSample1
                                 join v in db.VisitDetails on s.SampledBy equals v.MonitorId
                                 where v.MonitorId == userId && DbFunctions.DiffDays(v.VisitDate, DateTime.Now) == 1 && v.FactoryId==id && s.FactoryName== factoryName
                               select new List<long?> { s.SampleNumber};
            var lst = sampleNumber.ToList();

            var receivedSample = lst.Count()>0?db.UpdateConcreteReport(sampleNumber.FirstOrDefault().FirstOrDefault(), statusCode, statusMessage):0;

            return RedirectToAction("Home", "Home", new
            {
                id = 1
            });
        }


        public FileContentResult Docs()
        {
            // to get the user details to load user Image
            String Username = Session["Username"].ToString();

            var userImage = db.Users.Where(x => x.Username == Username).FirstOrDefault();
            if (userImage.Photo != null)
            {
                return new FileContentResult(userImage.Photo, "image/jpeg");
            }
            else
            {
                string fileName = HttpContext.Server.MapPath(@"~/Images/avatars/UserIcon.jpg");

                byte[] imageData = null;
                FileInfo fileInfo = new FileInfo(fileName);
                long imageFileLength = fileInfo.Length;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)imageFileLength);

                return File(imageData, "image/jpeg");
            }


        }

        public ActionResult ConcreteSampleReports()
        {
            var samples = db.ConcreteSample1.OrderByDescending(r => r.ReportDate).ToList();
            List<SampleReport> result = new List<SampleReport>();
            SampleReport s;
            if (samples.Count() > 0)
            {
                foreach (var sample in samples)
                {
                    s = new SampleReport
                    {
                        SampleNumber = sample.SampleNumber,
                        ReportedDate = sample.ReportDate,
                        FactoryName = sample.FactoryName,
                        MonitorName = db.Users.Where(u => u.Id == sample.SampledBy).FirstOrDefault().FullName,
                        CustomerName = sample.ClientName
                    };
                    result.Add(s);
                }
            }
            
            return View(result);
        }

        public ActionResult EditConcreteSampleReports(long Id)
        {
            ConcreteSample1 sample = db.ConcreteSample1.Where(s=>s.SampleNumber==Id).FirstOrDefault();
            
            return View(sample);
        }

        [HttpPost]
        public ActionResult UpdateConcreteSample(ConcreteSample1 sample)
        {
            ObjectParameter statusCode = new ObjectParameter("StatusCode", typeof(int));
            ObjectParameter statusMessage = new ObjectParameter("StatusMessage", typeof(string));


            if (Request.Files.Count > 0)
            {
                foreach (var file in Request.Files)
                {
                    byte[] docData = null;
                    HttpPostedFileBase docFile = Request.Files["Doc"];

                    using (var binary = new BinaryReader(docFile.InputStream))
                    {
                        docData = binary.ReadBytes(docFile.ContentLength);
                    }
                }

            }

            db.UpdateConcreteSample(sample.ReportNo, sample.ReportDate, sample.FactoryName, sample.FactoryLocation, sample.MixerNumber, sample.VisitNumber,
                                       sample.SampleNumber, sample.TruckNumber, sample.InvoiceNumber, sample.ClientName, sample.VisitLocation, sample.Latitude,
                                       sample.Longitude, sample.ConcreteRank, sample.ConcreteTemperture, sample.WaterTemperature, sample.WeatherTemperture,
                                       sample.DownAmount, sample.CementType, sample.CementSource, sample.AdditionType, sample.AdditionAmount, sample.CementWeight,
                                       sample.WaterWieght, sample.WashedSandWeight, sample.WhiteSandWeight, sample.Rubble3by4, sample.Rubble3by8, sample.IsCleanUsage,
                                       sample.IsBasicUsage, sample.IsColumnUsage, sample.IsRoofUsage, sample.IsOtherUsage, sample.IsCleanLocation, sample.CleanDocPath,
                                       sample.IsDustControlInStation, sample.DustDocPath, sample.IsRokamSummer, sample.SummerDocPath, sample.IsLabEngineer, sample.LabDocPath,
                                       sample.IsMoldanatInTrucks, sample.TruckDocPath, sample.IsPeopleSafty, sample.SafteyDocPath, 2, null, statusCode, statusMessage
                                         , sample.OtherReason, sample.CleanDocNote, sample.DustDocNote, sample.SummerDocNote, sample.LabDocNote, sample.TruckDocNote, sample.SafteyDocNote);


            return RedirectToAction("ConcreteSampleReports", "ConcreteFactoryReports");
        }
    }
}