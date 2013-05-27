using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Interfaces
{
	public class TransactionDB : IDisposable
	{
		public DbConnection Connection;
		public DbTransaction Transaction;

		public TransactionDB(string ConnectionString)
		{
			if (Connection == null)
			{
				Connection = new SqlConnection(ConnectionString);
			}
			else
			{
				Connection.ConnectionString = ConnectionString;
			}
			Connection.Open();
		}

		public void Dispose()
		{
			try
			{
				if (Connection.State == ConnectionState.Open)
					Connection.Close();
			}
			catch
			{
			}
		}

		~TransactionDB()
		{
			Dispose();
		}

		public void BeginTransaction()
		{
			try
			{
				Transaction = Connection.BeginTransaction();
			}
			catch (Exception e)
			{
				throw new Exception("Невозможно открыть транзакцию \n" +
					e.Message);
			}
		}

		public void BeginTransaction(IsolationLevel isolationLevel)
		{
			try
			{
				Transaction = Connection.BeginTransaction(isolationLevel);
			}
			catch (Exception e)
			{
				throw new Exception("Невозможно открыть транзакцию \n" +
					e.Message);
			}
		}

		public void RollBack()
		{
			if (null != Transaction)
			{
				Transaction.Rollback();
			}
			Transaction = null;
		}

		public void Commit()
		{
			if (null != Transaction)
			{
				Transaction.Commit();
			}
			Transaction = null;
		}

		private void KeepConnection(Object sender, StateChangeEventArgs e)
		{
			if (e.CurrentState == ConnectionState.Closed)
			{
				Connection.Open();
			}
		}

		public void Assign(DbCommand cmd)
		{
			cmd.Transaction = Transaction;
			cmd.Connection = Connection;
		}

		public int ExecuteNonQuery(DbCommand cmd)
		{
			int r = 0;
			DbConnection last = cmd.Connection;
			DbTransaction ltrans = cmd.Transaction;
			cmd.Transaction = Transaction;
			cmd.Connection = Connection;
			try
			{
				r = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				cmd.Connection = last;
				cmd.Transaction = ltrans;
				throw new Exception("Невозможно выполнить команду \n" + e.Message);
			}
			cmd.Connection = last;
			cmd.Transaction = ltrans;
			return r;
		}

		public object ExecuteScalar(DbCommand cmd)
		{
			object o = null;
			DbConnection last = cmd.Connection;
			DbTransaction ltrans = cmd.Transaction;
			cmd.Transaction = Transaction;
			cmd.Connection = Connection;
			try
			{
				o = cmd.ExecuteScalar();
			}
			catch (Exception e)
			{
				cmd.Connection = last;
				cmd.Transaction = ltrans;
				throw new Exception("Невозможно выполнить команду \n" + e.Message);
			}
			cmd.Connection = last;
			cmd.Transaction = ltrans;
			return o;
		}

		public DbCommand NewCommand()
		{
			return NewCommand("");
		}

		public DbCommand NewCommand(string cmd)
		{
			DbCommand Command = new SqlCommand();
			Command.Connection = (SqlConnection)Connection;
			Command.Transaction = Transaction;
			Command.CommandText = cmd;
			return Command;
		}
	}
}