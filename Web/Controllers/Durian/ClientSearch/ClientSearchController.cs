﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 3:04:15 AM
  From Machine: DESKTOP-517I8BU
  Template: sql2x.GenerateDurian.DurianController
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

namespace SolutionNorSolutionPort.AspMvc {
    public class ClientSearchController : Controller {

        [HttpGet]
        public ActionResult ClientSearchIndex() {

            return View(
                "~/Views/Durian/ClientSearch/ClientSearch.cshtml"
                );
        }

    }
}
