import { Component } from '@angular/core';
import { DepartmentsService } from './core/services/departments.service';
import { CountriesService } from './core/services/countries.service';
import { EmployeesService } from './core/services/employees.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'web';
  rspDep = '--';
  rspCtr = '--';
  rspEmp = '--';

  constructor(public service: DepartmentsService, public service2: CountriesService, public service3: EmployeesService) { }

  // tslint:disable-next-line: only-arrow-functions
  probar = function() {
    this.rspDep = 'En espera...';
    this.rspCtr = 'En espera...';
    this.rspEmp = 'En espera...';

    this.service.getAll().subscribe(
      items => {
        this.items = items;
        this.rspDep = 'Listo';
      }
    );

    this.service2.getAll().subscribe(
      items => {
        this.items = items;
        this.rspCtr = 'Listo';
      }
    );

    this.service3.getAll().subscribe(
      items => {
        this.items = items;
        this.rspEmp = 'Listo';
      }
    );
  };
}
