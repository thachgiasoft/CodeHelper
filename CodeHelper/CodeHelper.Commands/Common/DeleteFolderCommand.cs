﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeHelper.Core.Command;
using CodeHelper.Core.Services;

namespace CodeHelper.Commands.DataModel
{
    public class DeleteFolderCommand : BaseCommand
    {
        public string FolderName { get; set; }

        public override string Name
        {
            get
            {
                return Dict.Commands.RenameModel;
            }
        }

        IReceiver Receiver = null;

        public DeleteFolderCommand(IReceiver reciver)
        {
            this.Receiver = reciver;
        }

        public override void Execute()
        {
            this.Receiver.DeleteFolder(FolderName);
        }
    }
}
