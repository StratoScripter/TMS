﻿using System;
using System.Collections.Generic;
using DAL.Base.SQSConfig;
using Model;
using Model.SQSConfig;

namespace SQSClient
{
	// Token: 0x02000036 RID: 54
	public class BatchLabHelper
	{
		// Token: 0x06000284 RID: 644 RVA: 0x0004401C File Offset: 0x0004221C
		public string UpdateTicketLabStatus(int labStatus, ModT_ticketbatch modTBatch)
		{
			string text = string.Empty;
			bool flag = modTBatch == null;
			string result;
			if (flag)
			{
				text = Messages.LabWrong;
				result = text;
			}
			else
			{
				bool flag2 = labStatus - modTBatch.BatchLabStatus != 1;
				if (flag2)
				{
					text = Messages.LabStatusWrong;
					result = text;
				}
				else
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("BatchLabStatus", labStatus);
					bool flag3 = DalT_ticketbatch.Instance.Update(dictionary, modTBatch.Id);
					if (flag3)
					{
						this.AddtTicketLab(labStatus, modTBatch.Id, 3);
						text = Messages.SaveTrue;
					}
					else
					{
						text = Messages.ModifyFalse;
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000440B8 File Offset: 0x000422B8
		public string UpdateTicketLabStatus(int labStatus, ModT_unionlab modTUlab)
		{
			string text = string.Empty;
			bool flag = modTUlab == null;
			string result;
			if (flag)
			{
				text = Messages.LabWrong;
				result = text;
			}
			else
			{
				bool flag2 = labStatus - modTUlab.UnionLabStatus != 1;
				if (flag2)
				{
					text = Messages.LabStatusWrong;
					result = text;
				}
				else
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add("UnionLabStatus", labStatus);
					bool flag3 = DalT_unionlab.Instance.Update(dictionary, modTUlab.Id);
					if (flag3)
					{
						this.AddtTicketLab(labStatus, modTUlab.Id, 4);
						text = Messages.SaveTrue;
					}
					else
					{
						text = Messages.ModifyFalse;
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00044154 File Offset: 0x00042354
		private void AddtTicketLab(int labStatus, int billId, int billType)
		{
			ModT_ticketlab modT_ticketlab = new ModT_ticketlab();
			modT_ticketlab.BillId = billId;
			modT_ticketlab.BillType = billType;
			modT_ticketlab.LabStatus = labStatus;
			modT_ticketlab.CheckMan = GlobalKey.UserName;
			modT_ticketlab.LabTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			modT_ticketlab.LabInfo = "";
			modT_ticketlab.ModifyTime = DateTime.Now;
			modT_ticketlab.State = 1;
			DalT_ticketlab.Instance.AddNoReturn(modT_ticketlab);
		}
	}
}
