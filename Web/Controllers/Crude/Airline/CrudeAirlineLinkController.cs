﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/5/2021 2:02:55 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPort.AspMvc.Controllers {

    // this class serves as Controller to the data access layer between c# and sql server
    // primarily it calls the data access layer to get to the serialized CRUDE tables data
    //   and transfers that data with a REST API Contract using JSON string format
    // this contract is an identical representation of a Durian's columns
    //   formatted to follow C# casing guidelines ( Pascal casing )
    // links:
    //  docLink: http://sql2x.org/documentationLink/c30e2417-f529-43cb-9bc0-9d58745aa64f
    public class CrudeAirlineLinkController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeAirlineLinkIndex() {

            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkIndex.cshtml",
                new CrudeAirlineLinkServiceClient().FetchAll()
                );
        }

        // page with foreign key data
        // links:
        //  docLink: http://sql2x.org/documentationLink/a6014678-080e-4cb5-900e-738a6368a113
        [HttpGet]
        public ActionResult CrudeAirlineLinkByAirlineIndex(System.Guid airlineId) {
            ViewBag.AirlineId = airlineId;

            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkIndex.cshtml",
                new CrudeAirlineLinkServiceClient().FetchByAirlineId(airlineId)
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeAirlineLinkDetails(System.Guid airlineLinkId) {

            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkDetails.cshtml",
                new CrudeAirlineLinkServiceClient().FetchByAirlineLinkId(airlineLinkId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeAirlineLinkEdit(
            System.Guid airlineLinkId
            ) {

            CrudeAirlineLinkContract contract = new CrudeAirlineLinkServiceClient().FetchByAirlineLinkId(airlineLinkId);
            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.LinkTypeRcd =
                new SelectList( new CrudeLinkTypeRefServiceClient().FetchAll(),
                                "LinkTypeRcd",
                                "LinkTypeName",
                                contract.LinkTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirlineLinkEdit([Bind()] CrudeAirlineLinkContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeAirlineLinkServiceClient().Update(contract);

                return RedirectToAction("CrudeAirlineLinkIndex");
            }

            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeAirlineLinkCreate(System.Guid? airlineId, System.Guid? userId) {
            var contract = new CrudeAirlineLinkContract();
            if (airlineId != null) contract.AirlineId = (System.Guid) airlineId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.AirlineId =
                new SelectList( new CrudeAirlineServiceClient().FetchAll(),
                                "AirlineId",
                                "AirlineName",
                                contract.AirlineId
                                );

            ViewBag.LinkTypeRcd =
                new SelectList( new CrudeLinkTypeRefServiceClient().FetchAll(),
                                "LinkTypeRcd",
                                "LinkTypeName",
                                contract.LinkTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAirlineLinkCreate([Bind()] CrudeAirlineLinkContract contract) {
            if (ModelState.IsValid) {

                new CrudeAirlineLinkServiceClient().Insert(contract);

                return RedirectToAction("CrudeAirlineLinkIndex");
            }

            return View(
                "~/Views/Crude/Airline/CrudeAirlineLink/CrudeAirlineLinkCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeAirlineLinkDelete(
            System.Guid airlineLinkId
            ) {
            new CrudeAirlineLinkServiceClient().Delete(airlineLinkId);

            return RedirectToAction("CrudeAirlineLinkIndex");
        }
    }
}
