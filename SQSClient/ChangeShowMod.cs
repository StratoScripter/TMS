using System;
using Assistant;
using Base;
using DAL.Base.SQSConfig;
using Model;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x0200001D RID: 29
	public static class ChangeShowMod
	{
		// Token: 0x0600016B RID: 363 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		public static AutoShowModT_ticket TurnAuto(ModT_ticket mod)
		{
			AutoShowModT_ticket autoShowModT_ticket = ModelHelper.CopyModel<AutoShowModT_ticket, ModT_ticket>(mod);
			autoShowModT_ticket.BusinessType = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)mod.BusinessType));
			autoShowModT_ticket.AccountType = ShowWords.ReplaceText(EnumHelper.GetDescription<AccountType>((AccountType)mod.AccountType));
			autoShowModT_ticket.Status = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)mod.Status));
			autoShowModT_ticket.State = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)mod.State));
			autoShowModT_ticket.IsCard = ShowWords.ReplaceText(mod.IsCard.ToString());
			autoShowModT_ticket.IsQueue = ShowWords.ReplaceText(mod.IsQueue.ToString());
			autoShowModT_ticket.IsDelete = ShowWords.ReplaceText(mod.IsDelete.ToString());
			autoShowModT_ticket.DataReturn = ShowWords.ReplaceText((mod.DataReturn == 1).ToString());
			autoShowModT_ticket.TicketType = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketType>((TicketType)mod.TicketType));
			autoShowModT_ticket.IsVehicle = ShowWords.ReplaceText(mod.IsLab.ToString());
			autoShowModT_ticket.VehicleResult = ShowWords.ReplaceText(EnumHelper.GetDescription<CheckResult>((CheckResult)mod.LabResult));
			autoShowModT_ticket.IsLab = ShowWords.ReplaceText(mod.IsLab.ToString());
			autoShowModT_ticket.LabResult = ShowWords.ReplaceText(EnumHelper.GetDescription<CheckResult>((CheckResult)mod.LabResult));
			AutoShowModT_ticket autoShowModT_ticket2 = autoShowModT_ticket;
			ModT_client model = DalT_client.Instance.GetModel("Name", mod.ClientPart);
			autoShowModT_ticket2.CLicence = ((model != null) ? model.Licence : null);
			AutoShowModT_ticket autoShowModT_ticket3 = autoShowModT_ticket;
			ModT_client model2 = DalT_client.Instance.GetModel("Name", mod.SettlePart);
			autoShowModT_ticket3.SLicence = ((model2 != null) ? model2.Licence : null);
			ModT_truck model3 = DalT_truck.Instance.GetModel("Lisence", autoShowModT_ticket.Lisence);
			bool flag = model3 != null;
			if (flag)
			{
				autoShowModT_ticket.CoachNum = model3.CoachNum;
				autoShowModT_ticket.CTransportCode = model3.CTransportCode;
				autoShowModT_ticket.TypeName = model3.TypeName;
				autoShowModT_ticket.Vol = model3.Vol;
				autoShowModT_ticket.NetWeight = model3.NetWeight;
				autoShowModT_ticket.CangNum = model3.CangShu;
				autoShowModT_ticket.ValidDate = model3.ValidDate;
				autoShowModT_ticket.Lisence = model3.Lisence;
				autoShowModT_ticket.LTransportCode = model3.LTransportCode;
				autoShowModT_ticket.Weight = model3.Weight;
				autoShowModT_ticket.LoadWeight = model3.LoadWeight;
				autoShowModT_ticket.SubUnit = model3.SubUnit;
				AutoShowModT_ticket autoShowModT_ticket4 = autoShowModT_ticket;
				ModT_client model4 = DalT_client.Instance.GetModel("Name", model3.SubUnit);
				autoShowModT_ticket4.SubLicence = ((model4 != null) ? model4.Licence : null);
				autoShowModT_ticket.DriverID = model3.DriverID;
				autoShowModT_ticket.SupercargoID = model3.SupercargoID;
			}
			ModT_truckman model5 = DalT_truckman.Instance.GetModel("IDCard", mod.DriverID);
			bool flag2 = model5 != null;
			if (flag2)
			{
				autoShowModT_ticket.DriverName = model5.Name;
				autoShowModT_ticket.DriverCode = model5.DriverCode;
				autoShowModT_ticket.DQualifyCode = model5.QualifyCode;
			}
			ModT_truckman model6 = DalT_truckman.Instance.GetModel("IDCard", mod.SupercargoID);
			bool flag3 = model6 != null;
			if (flag3)
			{
				autoShowModT_ticket.SupercargoName = model6.Name;
				autoShowModT_ticket.SQualifyCode = model6.QualifyCode;
			}
			return autoShowModT_ticket;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0002D104 File Offset: 0x0002B304
		public static ShowModT_ticket DataChange(ModT_ticket mod)
		{
			ShowModT_ticket showModT_ticket = ModelHelper.CopyModel<ShowModT_ticket, ModT_ticket>(mod);
			showModT_ticket.BusinessType = ShowWords.ReplaceText(EnumHelper.GetDescription<BusinessType>((BusinessType)mod.BusinessType));
			showModT_ticket.AccountType = ShowWords.ReplaceText(EnumHelper.GetDescription<AccountType>((AccountType)mod.AccountType));
			showModT_ticket.Status = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketStatus>((TicketStatus)mod.Status));
			showModT_ticket.State = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketState>((TicketState)mod.State));
			showModT_ticket.IsCard = ShowWords.ReplaceText(mod.IsCard.ToString());
			showModT_ticket.IsQueue = ShowWords.ReplaceText(mod.IsQueue.ToString());
			showModT_ticket.IsDelete = ShowWords.ReplaceText(mod.IsDelete.ToString());
			showModT_ticket.DataReturn = ShowWords.ReplaceText((mod.DataReturn == 1).ToString());
			showModT_ticket.TicketType = ShowWords.ReplaceText(EnumHelper.GetDescription<TicketType>((TicketType)mod.TicketType));
			showModT_ticket.IsVehicle = ShowWords.ReplaceText(mod.IsLab.ToString());
			showModT_ticket.VehicleResult = ShowWords.ReplaceText(EnumHelper.GetDescription<CheckResult>((CheckResult)mod.LabResult));
			showModT_ticket.IsLab = ShowWords.ReplaceText(mod.IsLab.ToString());
			showModT_ticket.LabResult = ShowWords.ReplaceText(EnumHelper.GetDescription<CheckResult>((CheckResult)mod.LabResult));
			return showModT_ticket;
		}
	}
}
