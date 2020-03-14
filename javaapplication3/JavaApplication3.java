/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package thijava;

/**
 *
 * @author Dell
 */
abstract public class SalaryPolicy {
    float baseSalary;
    private double Salary;
    public SalaryPolicy(float baseSalary){
        this.baseSalary=baseSalary;
    }
    abstract public double getSalary();
    public void setBaseSalary(float baseSarary){
        this.baseSalary=baseSalary;
    }
    @Override
    public String toString(){
        return "SalaryPolicy{" + "Salary:"+ Salary+'}';
    }
}