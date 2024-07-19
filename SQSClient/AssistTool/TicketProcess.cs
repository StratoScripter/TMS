using System;
using System.Collections.Generic;
using DAL.Base.SQSConfig;
using Model.SQSConfig;

namespace SQSClient.AssistTool
{
	// Token: 0x020000A8 RID: 168
	internal class TicketProcess
	{
		// Token: 0x0600098F RID: 2447 RVA: 0x000DE9C8 File Offset: 0x000DCBC8
		public string GetProcessNameByCode(string processCode, ref string errinfo)
		{
			string text = null;
			try
			{
				ModSrm_step model = DalSrm_step.Instance.GetModel("StepCode", processCode);
				text = model.StepName;
				bool flag = text == null;
				if (flag)
				{
					throw new Exception();
				}
			}
			catch (Exception ex)
			{
				errinfo = "查询有误\r\n" + ex.Message + "错误";
			}
			finally
			{
			}
			return text;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000DEA48 File Offset: 0x000DCC48
		public List<string> GetNextProcessByTicketModel(ModT_ticket ticketModel, ref string errinfo)
		{
			List<string> list = new List<string>();
			try
			{
				string formula = "InvModelId = " + DalT_product.Instance.GetModelByInvCode(ticketModel.InvCode).InvModelId.ToString() + " AND LastStep = " + ticketModel.StepProcess;
				List<ModSrm_invstep> listRequire = DalSrm_invstep.Instance.GetListRequire(formula, null, null);
				foreach (ModSrm_invstep modSrm_invstep in listRequire)
				{
					bool flag = modSrm_invstep.StepCode != null;
					if (flag)
					{
						list.Add(this.GetProcessNameByCode(modSrm_invstep.StepCode, ref errinfo));
					}
				}
			}
			catch (Exception ex)
			{
				errinfo = "查询有误\r\n" + ex.Message + "错误";
			}
			finally
			{
			}
			return list;
		}
	}
}
