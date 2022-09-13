

var objBulk = new BulkUploadToSql<Person>()
{
    InternalStore = new List<Person>(),
    TableName = "tblPerson",
    CommitBatchSize = 1000,
    ConnectionString = "ENTER YOUR CONNECTION STRING"
};
objBulk.Commit();