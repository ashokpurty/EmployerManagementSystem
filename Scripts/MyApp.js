var app = angular.module('MyApp',['ngRoute']);

app.controller('employeeController', function($scope, $http){
    var employee = {};
    debugger;
    $scope.Message = "Message From anular";

    $scope.AddEmployee = function ()
    {
        employee.EmployeeCode = $scope.employeeCode;
        employee.FirstName = $scope.firstName;
        employee.Designation = $scope.designation;
        employee.DepartmentCode = $scope.departmentCode;
        employee.Designation = $scope.designation;  
        employee.EmployerId = $scope.employerId;

        debugger;
        $http.post('/Employee/PostEmployee', employee).then(function (data) { var result = data }, function (error) { alert("Something went wrong"); });
    }
});