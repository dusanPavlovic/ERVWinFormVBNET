Imports System.Data.Entity

Public Class ERVContext
    Inherits DbContext

    Property RegisterTimes As DbSet(Of RegisterTime)
    Property Employees As DbSet(Of Employee)


    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Entity(Of RegisterTime)().HasRequired(Of Employee)(Function(x) x.Employee).WithMany(Function(x) x.Times).HasForeignKey(Function(x) x.EmployeeId)



    End Sub

End Class
