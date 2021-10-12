// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using BlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using BlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\Pages\SearchAdults.razor"
using BlazorAssignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\Pages\SearchAdults.razor"
using BlazorAssignment.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SearchAdults")]
    public partial class SearchAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Latitude\Desktop\DNP\BlazorAssignmentPreFinalVersion\BlazorAssignment\BlazorAssignment\Pages\SearchAdults.razor"
       
    
    private IList<Adult> _adultList;
    private AdultsService _adultsService;
    private IList<Adult> _searchedList;
    
    private string SearchTermForFirstName { get; set; } = "";
    private string SearchTermForLastName { get; set; } = "";
    private string SearchTermForSex { get; set; } = "";

    private void SearchByFirstName() {
        
        _searchedList =  _adultList.Where(a => a.FirstName.Contains(SearchTermForFirstName)).ToList();
    }
    private void SearchByLastName() {
        
        _searchedList =  _adultList.Where(a => a.LastName.Contains(SearchTermForLastName)).ToList();
    }

    private void SearchBySex()
    {
        _searchedList =  _adultList.Where(a => a.Sex.Contains(SearchTermForSex.ToUpper() )).ToList();
    }
    protected override async Task OnInitializedAsync()
    {
        _adultsService = new AdultsService();
        
        _adultList =  _adultsService.ReadData<Adult>(); //   "adults.json"
    }
    
  
  

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
