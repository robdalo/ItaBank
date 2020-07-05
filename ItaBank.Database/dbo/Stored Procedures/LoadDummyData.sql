CREATE procedure dbo.LoadDummyData
as

	create table #accounts (
		Code nvarchar(20),
		Name nvarchar(100),
		Address nvarchar(255),
		Balance decimal(18,2)
	)

	create table #accountTransactions (
		AccountId int,
		Code nvarchar(20),
		Timestamp datetime,
		Type nvarchar(20),
		Amount decimal(18,2)
	)

	-- accounts

	insert into #accounts
	select 'AC0001', 'Mr Rob Daley', '10 Downing Street, Westminster, London, EC1 1LV', 25000 union all
	select 'AC0002', 'Miss Leanne Somebody', '11 Downing Street, Westminster, London, EC1 1LV', 50000

	merge into dbo.Account d
	using (
		select * from #accounts
	) s on (
		d.Code = s.Code
	)
	when matched then
		update set
			Name = s.Name,
			Address = s.Address,
			Balance = s.Balance
	when not matched then
		insert (
			Code,
			Name,
			Address,
			Balance
		)
		values (
			s.Code,
			s.Name,
			s.Address,
			s.Balance
		);

	-- accountTransactions

	declare @accountId int = (select Id from dbo.Account where Code = 'AC0001')

	insert into #accountTransactions
	select @accountId, 'TX0001', getdate(), 'DE', 5000 union all
	select @accountId, 'TX0002', getdate(), 'CR', 15000

	select @accountId = Id from dbo.Account where Code = 'AC0002'

	insert into #accountTransactions
	select @accountId, 'TX0003', getdate(), 'CR', 5000 union all
	select @accountId, 'TX0004', getdate(), 'CR', 15000 union all
	select @accountId, 'TX0005', getdate(), 'CR', 10000

	merge into dbo.AccountTransaction d
	using (
		select * from #accountTransactions
	) s on (
		d.AccountId = s.AccountId and
		d.Code = s.Code
	)
	when matched then
		update set
			Timestamp = s.Timestamp,
			Type = s.Type,
			Amount = s.Amount
	when not matched then
		insert (
			AccountId,
			Code,
			Timestamp,
			Type,
			Amount
		)
		values (
			s.AccountId,
			s.Code,
			s.Timestamp,
			s.Type,
			s.Amount
		);

	return