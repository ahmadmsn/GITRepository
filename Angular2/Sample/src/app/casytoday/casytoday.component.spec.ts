import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CASYTodayComponent } from './casytoday.component';

describe('CASYTodayComponent', () => {
  let component: CASYTodayComponent;
  let fixture: ComponentFixture<CASYTodayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CASYTodayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CASYTodayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
