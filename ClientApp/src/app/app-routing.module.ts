import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RecordComponent } from './components/record/record.component';
import { SearchComponent } from './components/search/search.component';
import { Routes, RouterModule } from '@angular/router';



const routes: Routes = [
  /*{
    path:'',
    component:Component
  },*/
  {
    path:'record',
    component:RecordComponent
  },
  {
    path:'search',
    component:SearchComponent
  }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
