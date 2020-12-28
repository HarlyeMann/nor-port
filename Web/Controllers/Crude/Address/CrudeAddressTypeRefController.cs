﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/28/2020 7:54:52 AM
  From Machine: DESKTOP-BP3OHLH
  Template: sql2x.TemplateFromCrudeMvcGenerator.ControllerBeginning
*/
using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Web.Mvc;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/f4564569-78eb-4ce4-99f3-6ace286090c3
namespace SolutionNorSolutionPort.AspMvc.Controllers {

    // controller class for mvc
    // links:
    //  docLink: http://sql2x.org/documentationLink/bc619e06-279f-4682-825d-3d1aef43067f
    public class CrudeAddressTypeRefController : Controller {

        // index page for controller
        // links:
        //  docLink: http://sql2x.org/documentationLink/29a8e912-027b-4a95-9dda-d194d98f79f6
        [HttpGet]
        public ActionResult CrudeAddressTypeRefIndex() {

            return View(
                "~/Views/Crude/Address/CrudeAddressTypeRef/CrudeAddressTypeRefIndex.cshtml",
                new CrudeAddressTypeRefServiceClient().FetchAll()
                );
        }

        // fetch detail page for editing
        // links:
        //  docLink: http://sql2x.org/documentationLink/55a68144-0799-4728-af2a-07d9fa9a710d
        [HttpGet]
        public ActionResult CrudeAddressTypeRefDetails(System.String addressTypeRcd) {

            return View(
                "~/Views/Crude/Address/CrudeAddressTypeRef/CrudeAddressTypeRefDetails.cshtml",
                new CrudeAddressTypeRefServiceClient().FetchByAddressTypeRcd(addressTypeRcd)
                );
        }

        // edit details page
        // links:
        //  docLink: http://sql2x.org/documentationLink/3e99a2da-0244-4d1a-a2a1-ad4dd84d8a42
        [HttpGet]
        public ActionResult CrudeAddressTypeRefEdit(
            System.String addressTypeRcd
            ) {

            CrudeAddressTypeRefContract contract = new CrudeAddressTypeRefServiceClient().FetchByAddressTypeRcd(addressTypeRcd);

            return View(
                "~/Views/Crude/Address/CrudeAddressTypeRef/CrudeAddressTypeRefEdit.cshtml",
                contract
                );
        }

        // save detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/a3d2b1b6-1b6a-49c8-b18e-b29f3f80ffd8
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAddressTypeRefEdit([Bind()] CrudeAddressTypeRefContract contract) {
            if (ModelState.IsValid) {
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

                contract.DateTime = DateTime.UtcNow;

                new CrudeAddressTypeRefServiceClient().Update(contract);

                return RedirectToAction("CrudeAddressTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Address/CrudeAddressTypeRef/CrudeAddressTypeRefEdit.cshtml",
                contract
                );
        }

        // add new entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/d1da3134-13e5-4ad2-95ec-d7ebbd0a61f9
        [HttpGet]
        public ActionResult CrudeAddressTypeRefCreate(System.Guid? userId) {
            var contract = new CrudeAddressTypeRefContract();
            if (userId != null) contract.UserId = (System.Guid) userId;

            if (userId == null)
                contract.UserId = new System.Guid("{FFFFFFFF-5555-5555-5555-FFFFFFFFFFFF}");

            contract.DateTime = DateTime.UtcNow;


            return View(
                "~/Views/Crude/Address/CrudeAddressTypeRef/CrudeAddressTypeRefCreate.cshtml",
                contract
                );
        }

        // add new detail page
        // links:
        //  docLink: http://sql2x.org/documentationLink/573ed4a9-77d8-41d3-a6f1-2453d631ced2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrudeAddressTypeRefCreate([Bind()] CrudeAddressTypeRefContract contract) {
            if (ModelState.IsValid) {

                new CrudeAddressTypeRefServiceClient().Insert(contract);

                return RedirectToAction("CrudeAddressTypeRefIndex");
            }

            return View(
                "~/Views/Crude/Address/CrudeAddressTypeRef/CrudeAddressTypeRefCreate.cshtml",
                contract
                );
        }

        // delete entity page
        // links:
        //  docLink: http://sql2x.org/documentationLink/b915f3c6-f624-4c82-98bc-ff9b9d74ba9b
        [HttpGet]
        public ActionResult CrudeAddressTypeRefDelete(
            System.String addressTypeRcd
            ) {
            new CrudeAddressTypeRefServiceClient().Delete(addressTypeRcd);

            return RedirectToAction("CrudeAddressTypeRefIndex");
        }
    }
}
