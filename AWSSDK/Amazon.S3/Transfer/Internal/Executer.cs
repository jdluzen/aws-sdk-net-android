﻿/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Transfer.Internal
{
    internal class Executer
    {
        TransferAsyncResult _asyncResult;
        BaseCommand _command;

        internal Executer(TransferAsyncResult asyncResult, BaseCommand command)
        {
            this._asyncResult = asyncResult;
            this._command = command;
        }

        internal void Execute()
        {
            try
            {
                this._command.Execute();
                this._asyncResult.Return = this._command.Return;

            }
            catch (Exception e)
            {
                this._asyncResult.LastException = e;
            }
            finally
            {
                this._asyncResult.SignalWaitHandle();
                if (this._asyncResult.Callback != null)
                {
                    this._asyncResult.Callback(this._asyncResult);
                }
            }
        }
    }
}
