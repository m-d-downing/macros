import { Routes } from '@angular/router';
import { DashboardPage } from './pages/dashboard/dashboard.component';
import { TargetsPage } from './pages/targets/targets.component';

export const routes: Routes = [
    { path: "", component: DashboardPage },
    { path: "targets", component: TargetsPage }
];
