﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using RadzenCrm.Models.Crm;
using Microsoft.EntityFrameworkCore;

namespace RadzenCrm.Pages
{
    public partial class OpportunityStatusesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected CrmService Crm { get; set; }
        protected RadzenDataGrid<RadzenCrm.Models.Crm.OpportunityStatus> grid0;

        IEnumerable<RadzenCrm.Models.Crm.OpportunityStatus> _getOpportunityStatusesResult;
        protected IEnumerable<RadzenCrm.Models.Crm.OpportunityStatus> getOpportunityStatusesResult
        {
            get
            {
                return _getOpportunityStatusesResult;
            }
            set
            {
                if (!object.Equals(_getOpportunityStatusesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getOpportunityStatusesResult", NewValue = value, OldValue = _getOpportunityStatusesResult };
                    _getOpportunityStatusesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var crmGetOpportunityStatusesResult = await Crm.GetOpportunityStatuses();
            getOpportunityStatusesResult = crmGetOpportunityStatusesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddOpportunityStatus>("Add Opportunity Status", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(RadzenCrm.Models.Crm.OpportunityStatus args)
        {
            var dialogResult = await DialogService.OpenAsync<EditOpportunityStatus>("Edit Opportunity Status", new Dictionary<string, object>() { {"Id", args.Id} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var crmDeleteOpportunityStatusResult = await Crm.DeleteOpportunityStatus(data.Id);
                    if (crmDeleteOpportunityStatusResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception crmDeleteOpportunityStatusException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete OpportunityStatus" });
            }
        }
    }
}
