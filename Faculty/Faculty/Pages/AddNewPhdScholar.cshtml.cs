﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Faculty.Data;
using Faculty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Faculty.Pages
{
    public class AddNewPhdScholarModel : PageModel
    {
        private readonly PhdStudentsDbContext phdStudentsDbContext;
        private readonly ProfileDbContext profileDbContext;

        [BindProperty]
        public PhdStudents Student { get; set; }

        public AddNewPhdScholarModel(PhdStudentsDbContext phd,ProfileDbContext prdb)
        {
            phdStudentsDbContext = phd;
            profileDbContext = prdb;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if(!User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(User.Identity.IsAuthenticated)
            {
                if(ModelState.IsValid)
                {
                    string emaiID = User.FindFirst(ClaimTypes.Email).Value;
                    var supervisor = await profileDbContext.Profiles.SingleOrDefaultAsync(m => m.LoginEmailID == emaiID);
                    Student.SupervisorID = supervisor.ID;
                    await phdStudentsDbContext.PhdStudents.AddAsync(Student);
                    await phdStudentsDbContext.SaveChangesAsync();
                    return RedirectToPage("/EditPhdScholarsPage");
                }
                else
                {
                    return Page();
                }
            }
            else
            {
                return RedirectToPage("/Error");
            }
        }
    }
}