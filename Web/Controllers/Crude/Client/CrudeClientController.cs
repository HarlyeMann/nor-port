﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:20:26 PM
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
    public class CrudeClientController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeClientIndex() {

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientIndex.cshtml",
                new CrudeClientServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeClientDetails(System.Guid clientId) {

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientDetails.cshtml",
                new CrudeClientServiceClient().FetchByClientId(clientId)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeClientEdit(
            System.Guid clientId
            ) {

            CrudeClientContract contract = new CrudeClientServiceClient().FetchByClientId(clientId);
            ViewBag.PassengerTypeRcd =
                new SelectList( new CrudePassengerTypeRefServiceClient().FetchAll(),
                                "PassengerTypeRcd",
                                "PassengerTypeName",
                                contract.PassengerTypeRcd
                                );

            ViewBag.NationalityRcd =
                new SelectList( new CrudeNationalityRefServiceClient().FetchAll(),
                                "NationalityRcd",
                                "NationalityName",
                                contract.NationalityRcd
                                );

            ViewBag.GenderRcd =
                new SelectList( new CrudeGenderRefServiceClient().FetchAll(),
                                "GenderRcd",
                                "GenderName",
                                contract.GenderRcd
                                );

            ViewBag.TitleRcd =
                new SelectList( new CrudeTitleRefServiceClient().FetchAll(),
                                "TitleRcd",
                                "TitleName",
                                contract.TitleRcd
                                );

            ViewBag.ClientTypeRcd =
                new SelectList( new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;


            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientEdit([Bind()] CrudeClientContract contract) {
            if (ModelState.IsValid) {
                contract.DateTime = DateTime.UtcNow;

                new CrudeClientServiceClient().Update(contract);

                return RedirectToAction("CrudeClientIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeClientCreate(System.Guid? addressId, System.Guid? defaultUserId, System.Guid? userId) {
            var contract = new CrudeClientContract();
            if (addressId != null) contract.AddressId = (System.Guid) addressId;
            if (defaultUserId != null) contract.DefaultUserId = (System.Guid) defaultUserId;
            if (userId != null) contract.UserId = (System.Guid) userId;

            ViewBag.PassengerTypeRcd =
                new SelectList( new CrudePassengerTypeRefServiceClient().FetchAll(),
                                "PassengerTypeRcd",
                                "PassengerTypeName",
                                contract.PassengerTypeRcd
                                );

            ViewBag.NationalityRcd =
                new SelectList( new CrudeNationalityRefServiceClient().FetchAll(),
                                "NationalityRcd",
                                "NationalityName",
                                contract.NationalityRcd
                                );

            ViewBag.GenderRcd =
                new SelectList( new CrudeGenderRefServiceClient().FetchAll(),
                                "GenderRcd",
                                "GenderName",
                                contract.GenderRcd
                                );

            ViewBag.TitleRcd =
                new SelectList( new CrudeTitleRefServiceClient().FetchAll(),
                                "TitleRcd",
                                "TitleName",
                                contract.TitleRcd
                                );

            ViewBag.ClientTypeRcd =
                new SelectList( new CrudeClientTypeRefServiceClient().FetchAll(),
                                "ClientTypeRcd",
                                "ClientTypeName",
                                contract.ClientTypeRcd
                                );

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            ViewBag.DefaultUserName =
                new CrudeDefaultUserServiceClient().FetchByDefaultUserId(contract.UserId).DefaultUserName;

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeClientCreate([Bind()] CrudeClientContract contract) {
            if (ModelState.IsValid) {

                new CrudeClientServiceClient().Insert(contract);

                return RedirectToAction("CrudeClientIndex");
            }

            return View(
                "~/Views/Crude/Client/CrudeClient/CrudeClientCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeClientDelete(
            System.Guid clientId
            ) {
            new CrudeClientServiceClient().Delete(clientId);

            return RedirectToAction("CrudeClientIndex");
        }
    }
}
