﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/31/2020 10:59:10 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class AircraftMaintenanceSearchController : Controller {

        [HttpGet]
        public ActionResult AircraftMaintenanceSearchIndex() {

            return View(
                "~/Views/Durian/AircraftMaintenanceSearch/AircraftMaintenanceSearch.cshtml"
                );
        }

    }
}
